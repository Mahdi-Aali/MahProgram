using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MahProgram.DataAccess.IdentityContext;

public class IdentityDataContext : IdentityDbContext<IdentityUser<long>, IdentityRole<long>, long>
{
	public IdentityDataContext(DbContextOptions<IdentityDataContext> options) : base(options)
	{

	}
}
