using MyWebsite.Core.Sharedkernel;
using MyWebsite.Data.Enums;
using MyWebsite.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebsite.Data.Entities
{
	[Table("Bills")]
	public class Bill : DomainEntity<long>, IDateChecking
	{
		[Required]
		[StringLength(255)]
		public string CustomerName { get; set; }
		[Required]
		[StringLength(255)]
		public string CustomerAddress { get; set; }
		[Required]
		[StringLength(255)]
		public string CustomerPhone { get; set; }
		[Required]
		[MaxLength(256)]
		public string CustomerMessage { set; get; } 

		public PaymentMethod PaymentMethod { set; get; }
		public BillStatus BillStatus { set; get; }
		[DefaultValue(Status.Active)]
		public Status Status { set; get; } = Status.Active;

		public Guid? CustomerId { set; get; }

		[ForeignKey("CustomerId")]
		public virtual AppUser User { set; get; }

		public DateTime DateCreated { get; set; }
		public DateTime DateModified { get; set; }
	}
}
