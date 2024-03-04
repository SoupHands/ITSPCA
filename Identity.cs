using Microsoft.AspNetCore.Identity;
using Microsoft.VisualStudio.Services.UserAccountMapping;

namespace ITSPCA
{
	public class AppUser : IdentityUser
	{
		public int UserRoleId { get; set; }
		public UserRole UserRole { get; set; }
	}
}
