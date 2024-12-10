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
	[Table("AdvertistmentPages")]
	public class AdvertisementPage : DomainEntity<string>
	{
		[StringLength(255)]
		public string Name { get; set; }

		public virtual ICollection<AdvertisementPosition> AdvertisementPositions { get; set; }
	}
}
