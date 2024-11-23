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
	[Table("Slides")]
	public class Slide : DomainEntity<int>, ISortable
	{
		[Required]
		[StringLength(255)]
		public string Name {  get; set; }
		[Required]
		[StringLength(255)]
		public string Url {  get; set; }
		[Required]
		[StringLength(255)]
		public string Image {  get; set; }
		[Required]
		[StringLength(255)]
		public string Text {  get; set; }
		public Status Status { get; set; }
		public int SortOrder { get; set; }
	}
}
