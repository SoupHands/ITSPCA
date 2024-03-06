using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;


namespace ITSPCA.Models
{
	[Authorize(Roles = "Manager")]
	public class TimeApproval : PageModel
	{

		private readonly TimesheetService _timesheetService;

		public TimeApproval(TimesheetService timesheetService)
		{
			_timesheetService = timesheetService;
		}

		public List<Timesheet> SubmittedTimesheets { get; set; }

		public void OnGet()
		{
			SubmittedTimesheets = _timesheetService.GetSubmittedTimesheets();
		}

		public IActionResult OnPost(int timesheetId, string action)
		{
			if (action == "approve")
			{
			}
			else if (action == "modify")
			{
			}

			return RedirectToPage("/Manager/TimeApproval");
		}
	}
	}
