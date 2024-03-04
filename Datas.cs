using Microsoft.AspNetCore.Identity;

namespace ITSPCA
{
	public class Datas
	{
		public static class SeedData
		{
			public static async Task InitializeAsync(IServiceProvider serviceProvider)
			{
				var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

				string[] roleNames = { "Manager", "Intern" };
				IdentityResult roleResult;

				foreach (var roleName in roleNames)
				{
					var roleExist = await roleManager.RoleExistsAsync(roleName);
					if (!roleExist)
					{
						roleResult = await roleManager.CreateAsync(new IdentityRole(roleName));
					}
				}
			}
		}

	}
}
