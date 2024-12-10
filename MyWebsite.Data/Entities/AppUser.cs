using Microsoft.AspNetCore.Identity;
using MyWebsite.Data.Enums;
using MyWebsite.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebsite.Data.Entities
{
	[Table("AppUsers")]
	public class AppUser : IdentityUser<Guid>, IDateChecking, ISwitchable
	{
		public string FullName { get; set; }
		public DateTime? BirthDate { get; set; }
		public string? Avatar {  get; set; }
		public decimal Balance {  get; set; }
		public DateTime DateCreated { get; set; }
		public DateTime DateModified { get; set; }
		public Status Status { get; set; }
	}
}
