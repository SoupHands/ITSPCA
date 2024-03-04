using static ITSPCA.Datas;

namespace ITSPCA

{
	public class Startup
	{
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
{
    // ...

    using (var serviceScope = app.ApplicationServices.CreateScope())
    {
        var serviceProvider = serviceScope.ServiceProvider;
				SeedData.InitializeAsync(serviceProvider);
    }
}
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddAuthorization(options =>
			{
				options.AddPolicy("Manager", policy => policy.RequireRole("Manager"));
				options.AddPolicy("Intern", policy => policy.RequireRole("Intern"));
			});

			
		}


	}
}
