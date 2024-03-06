using ITSPCA.Data;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using static ITSPCA.Datas;

namespace ITSPCA

{
	public class Startup
	{
		public IConfiguration Configuration { get; }

		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
{
   

    using (var serviceScope = app.ApplicationServices.CreateScope())
    {
        var serviceProvider = serviceScope.ServiceProvider;
				SeedData.InitializeAsync(serviceProvider);
    }
}
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddDbContext<ApplicationDbContext>(options =>
	   options.UseSqlServer(Configuration.GetConnectionString("TimeConnection")));

			services.AddAuthorization(options =>
			{
				options.AddPolicy("Manager", policy => policy.RequireRole("Manager"));
				options.AddPolicy("Intern", policy => policy.RequireRole("Intern"));
			});

			
		}


	}
}
