namespace ITSPCA.Models
{
	public class Timesheet
	{
		public int TimesheetId { get; set; }
		public string EmployeeId { get; set; }
		public DateTime WorkDate { get; set; }
		public DateTime TimeIn { get; set; }
		public DateTime TimeOut { get; set; }
		public double HoursWorked { get; set; }
	}
}
