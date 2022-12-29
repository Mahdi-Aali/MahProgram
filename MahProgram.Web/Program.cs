using MahProgram.DataAccess.Context;
using MahProgram.DataAccess.IdentityContext;
using MahProgram.DataAccess.Repositories.ContactUsAnswereRepositories;
using MahProgram.DataAccess.Repositories.ContactUsRepositories;
using MahProgram.DataAccess.Repositories.EmployeeRepository;
using MahProgram.DataAccess.Repositories.ProjectRepository;
using MahProgram.DataAccess.Repositories.ServiceRepository;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);

var services = builder.Services;
var configuration = builder.Configuration;

services.AddControllersWithViews();
services.AddRazorPages();
services.AddServerSideBlazor();

services.AddDbContext<MahProgramDBContext>(opt =>
{
    opt.UseSqlServer(configuration["ConnectionStrings:Default"], sqlOptions =>
    {
        sqlOptions.MigrationsAssembly("MahProgram.Web");
    });
});

services.AddDbContext<IdentityDataContext>(opt =>
{
    opt.UseSqlServer(configuration["ConnectionStrings:Identity"], sqlOptions =>
    {
        sqlOptions.MigrationsAssembly("MahProgram.Web");
    });
});

services.AddIdentity<IdentityUser<long>, IdentityRole<long>>(opt =>
{
    opt.SignIn.RequireConfirmedPhoneNumber = true;
    opt.SignIn.RequireConfirmedEmail = true;
    opt.User.RequireUniqueEmail = true;
})
.AddEntityFrameworkStores<IdentityDataContext>()
.AddDefaultTokenProviders();

services.Configure<CookieAuthenticationOptions>(IdentityConstants.ExternalScheme, opt =>
{
    opt.LoginPath = "/Login";
    opt.LogoutPath = "/LogOut";
    opt.AccessDeniedPath = "/Errors/NotFound";
});



services.AddScoped<IContactUsRepository, EFContactUsRepository>();
services.AddScoped<IContactUsAnswereRepository, EFContactUsAnswereRepository>();
services.AddScoped<IServiceRepository, EFServiceRepository>();
services.AddScoped<IEmployeeRepository, EFEmployeeRepository>();
services.AddScoped<IProjectRepository, EFProjectRepository>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseStatusCodePagesWithRedirects("/Errors/NotFound");

app.UseStaticFiles();
app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "Images")),
    RequestPath = "/Images"
});

app.UseAuthentication();
app.UseAuthorization();


app.MapDefaultControllerRoute();
app.MapRazorPages();
app.MapBlazorHub();

MahProgramContextSeedData.SeedData(app.Services.CreateScope().ServiceProvider.GetRequiredService<MahProgramDBContext>());
IdentityContextSeedData.SeedData(app.Services);

app.Run();