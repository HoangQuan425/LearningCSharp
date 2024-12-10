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
	[Table("AdvertistmentPositions")]
	public class AdvertisementPosition : DomainEntity<string>
	{
		public string PageId { get; set; }

		[StringLength(250)]
		public string Name { get; set; }

		[ForeignKey("PageId")]
		public virtual AdvertisementPage AdvertistmentPage { get; set; }

	}
}
