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
	public class Anoucement : DomainEntity<string>, ISwitchable, IDateChecking
	{
		[Required]
		[StringLength(250)]
		public string Tittle { get; set; }
		[StringLength(250)]
		public string Content { get; set; }
		[StringLength(450)]
		public string UserId { get; set; }
		//[ForeignKey("UserId")]
		//public virtual AppUser AppUser { get; set; }
		public virtual AnoucementUser AnoucementUsers { get; set; }
		public DateTime DateCreated { get; set; }
		public DateTime DateModified { get; set; }
		public Status Status { get; set; }
	}
}
