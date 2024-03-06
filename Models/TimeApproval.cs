using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace ITSPCA.Models
{
	[Authorize(Roles = "Manager")]
	public class TimeApproval : PageModel
	{
    
			public List<Timesheet> SubmittedTimesheets { get; set; }

			public void OnGet()
			{
			
				SubmittedTimesheets = YourTimesheetService.GetSubmittedTimesheets();
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
