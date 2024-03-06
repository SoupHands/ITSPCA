using ITSPCA.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;

namespace ITSPCA.Pages
{

	public class TimeTrackingModel : PageModel
	{
		private readonly ApplicationDbContext _context;

		public TimeTrackingModel(ApplicationDbContext context)
		{
			_context = context;
		}

		public IActionResult OnGet()
		{
			// get from DB (need to make DB)
			var timesheet = _context.Timesheet.ToList();

			return Page();
		}
	}

}
