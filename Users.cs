﻿namespace ITSPCA
{
	public class Users
	{
		public int User { get; set; }
		public string UserName { get; set; }

		public ICollection<AppUser> Users {  get; set; }
	}
}
