using MahProgram.DataAccess.Models.ContactUsModel;
using Microsoft.EntityFrameworkCore;

namespace MahProgram.DataAccess.Context;

public sealed partial class MahProgramDBContext
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ContactUsAnswere>()
            .HasOne(x => x.ContactUs)
            .WithOne(x => x.ContactUsAnswere)
            .HasForeignKey<ContactUsAnswere>(fk => fk.ContactUsId);

        base.OnModelCreating(modelBuilder);
    }
}
