using Microsoft.EntityFrameworkCore;

namespace MahProgram.DataAccess.Context;

public class MahProgramContextSeedData
{
	public static void SeedData(MahProgramDBContext context)
	{
		SeedDataAsync(context).Wait();
	}

	private static async Task SeedDataAsync(MahProgramDBContext context)
	{
		if ((await context.Database.GetPendingMigrationsAsync()).Any())
		{
			await context.Database.MigrateAsync();
		}
	}

}
