using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace MahProgram.DataAccess.IdentityContext;

public class IdentityContextSeedData
{
    public static void SeedData(IServiceProvider serviceProvider)
    {
        SeedDataAsync(serviceProvider).Wait();
    }
    private static async Task SeedDataAsync(IServiceProvider serviceProvider)
    {
        var service = serviceProvider.CreateScope().ServiceProvider;
        UserManager<IdentityUser<long>> userManager = service.GetRequiredService<UserManager<IdentityUser<long>>>();
        RoleManager<IdentityRole<long>> roleManager = service.GetRequiredService<RoleManager<IdentityRole<long>>>();
        IdentityDataContext context = service.GetRequiredService<IdentityDataContext>();

        if ((await context.Database.GetPendingMigrationsAsync()).Any())
        {
            await context.Database.MigrateAsync();
        }

        if (!await roleManager.RoleExistsAsync("Admin"))
        {
            await roleManager.CreateAsync(new()
            {
                Name = "Admin"
            });
           
        }

        if (await userManager.FindByNameAsync("Admin") is null)
        {
            await userManager.CreateAsync(new IdentityUser<long>()
            {
                UserName = "Admin",
                Email = "info@mahprogram.com",
                EmailConfirmed = true,
                PhoneNumber = "+989052730661",
                PhoneNumberConfirmed = true
            }, "M4|-|d1@4l1$Ma7415369");
            await userManager.AddToRoleAsync(await userManager.FindByNameAsync("Admin"), "Admin");
        }
    }
}
