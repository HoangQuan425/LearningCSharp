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
	public class Advertisement : DomainEntity<int>, ISwitchable, ISortable, IDateChecking
	{
		[StringLength(250)]
		public string Name {  get; set; }
		[StringLength(250)]
		public string Description { get; set; }
		[StringLength(250)]
		public string Image { get; set; }
		[StringLength(250)]
		public string Url { get; set; }
		[StringLength(20)]
		public string PositionId { get; set; }
		[ForeignKey("PositionId")]
		public virtual AdvertisementPosition AdvertisementPosition { get; set; }
		public int SortOrder { get; set; }
		public Status Status { get; set; }
		public DateTime DateCreated { get; set; }
		public DateTime DateModified { get; set; }
	}
}
