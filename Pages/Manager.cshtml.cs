using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ITSPCA.Pages
{
    public class TimeApporval : PageModel
    {
        public List<Timesheet> SubmittedTimesheet {  get; set; }
        public void OnGet()
        {
        }
    }
}
