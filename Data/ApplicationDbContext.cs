using ITSPCA.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ITSPCA.Data
{
	public class ApplicationDbContext : IdentityDbContext
	{
		public DbSet<Timesheet> timesheets {  get; set; }
		public object Timesheet { get; internal set; }

		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}
	}
}
