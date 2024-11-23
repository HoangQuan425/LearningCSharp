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
	[Table("Blogs")]
	public class Blog : DomainEntity<int>, IHasSeoMetaData, IDateChecking
	{
		[Required]
		[StringLength(255)]
		public string Name { get; set; }
		[Required]
		[StringLength(8000)]
		public string Description { get; set; }
		[Required]
		[StringLength(255)]
		public string Content { get; set; }
		[Required]
		[StringLength(256)]
		public string Image {  get; set; }

		public bool? HomeFlag { set; get; }
		public bool? HotFlag { set; get; }
		public int? ViewCount { set; get; }

		public string Tags { get; set; }
		public virtual ICollection<BlogTag> BlogTags { set; get; }

		[StringLength(255)]
		public string SeoPageTittle { get; set; }
		[Column(TypeName = "varchar")]
		[StringLength(255)]
		public string SeoAlias { get; set; }
		[StringLength(255)]
		public string SeoKeywords { get; set; }
		[StringLength(255)]
		public string SeoDescription { get; set; }
		public Status Status { get; set; }
		public DateTime DateCreated { set; get; }
		public DateTime DateModified { set; get; }
	}
}
