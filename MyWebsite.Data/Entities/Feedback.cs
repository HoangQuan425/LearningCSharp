using MyWebsite.Core.Sharedkernel;
using MyWebsite.Data.Enums;
using MyWebsite.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebsite.Data.Entities
{
	[Table("Feedbacks")]
	public class Feedback : DomainEntity<int>, ISwitchable, IDateChecking
	{
		[StringLength(250)]
		[Required]
		public string Name { set; get; }

		[StringLength(250)]
		public string Email { set; get; }

		[StringLength(500)]
		public string Message { set; get; }

		public Status Status { set; get; }
		public DateTime DateCreated { set; get; }
		public DateTime DateModified { set; get; }
	}
}
