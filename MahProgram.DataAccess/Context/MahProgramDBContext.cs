using MahProgram.DataAccess.Models.ContactUsModel;
using MahProgram.DataAccess.Models.EmployeeModel;
using MahProgram.DataAccess.Models.ProjectModel;
using MahProgram.DataAccess.Models.ServiceModel;
using Microsoft.EntityFrameworkCore;

namespace MahProgram.DataAccess.Context;

public sealed partial class MahProgramDBContext : DbContext
{
    public MahProgramDBContext(DbContextOptions<MahProgramDBContext> options) : base(options)
    {

    }

    public DbSet<ContactUs> ContactUs => Set<ContactUs>();
    public DbSet<ContactUsAnswere> ContactUsAnsweres => Set<ContactUsAnswere>();
    public DbSet<Service> Services => Set<Service>();
    public DbSet<Employee> Employees => Set<Employee>();
    public DbSet<Project> Projects => Set<Project>();
}