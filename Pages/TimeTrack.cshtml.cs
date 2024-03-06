using ITSPCA.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

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
			var timesheets = _context.Timesheets.ToList();

			return Page();
		}
	}

}
