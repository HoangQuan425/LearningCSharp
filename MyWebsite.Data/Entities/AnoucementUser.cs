using MyWebsite.Core.Sharedkernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebsite.Data.Entities
{
	public class AnoucementUser : DomainEntity<int>
	{
		public string AnoucementId { get; set; }

		[StringLength(450)]
		[Required]
		public Guid UserId { get; set; }
		public bool? HasRead { get; set; }
	
		[ForeignKey("AnoucementId")]
		public virtual Anoucement Anoucement { get; set; }
	}
}
