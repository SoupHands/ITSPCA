using ITSPCA.Data;
using ITSPCA.Models;

namespace ITSPCA
{
	public class TimesheetService
	{
		private readonly ApplicationDbContext _context;

		public TimesheetService(ApplicationDbContext context)
		{
			_context = context;
		}

		public List<Timesheet> GetSubmittedTimesheets()
		{
			return _context.Timesheet.Where(t => t.Status == TimesheetStatus.Submitted).ToList();
		}
	}
}

	

