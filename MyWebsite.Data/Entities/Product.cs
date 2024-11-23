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
	[Table("Products")]
	public class Product : DomainEntity<int>, IHasSeoMetaData, ISwitchable, ISortable, IDateChecking
	{
		[Required]
		[StringLength(25)]
		public string Name { get; set; }

		[Required]
		public int CategoryId { get; set; }
		[ForeignKey("CategoryId")]
		public virtual ProductCategory ProductCategory { get; set; }
		[StringLength(255)]
		public string Image { get; set; }
		[Required]
		[DefaultValue(0)]
		public decimal Price { get; set; }
		public decimal PromotionPrice { get; set; }
		public decimal OriginPrice { set; get; }
		[StringLength(8000)]
		public string Description { get; set; }
		public string Content { get; set; }
		public bool? HomeFlag { get; set; }
		public bool? HotFlag { get; set; }
		public int? ViewCount { get; set; }
		[StringLength(255)]
		public string Tags { get; set; }
		[StringLength(255)]
		public string Unit { get; set; }


		public DateTime DateCreated { set; get; }
		public DateTime DateModified { set; get; }
		public int SortOrder { set; get; }
		public Status Status { set; get; }
		public string SeoPageTittle { set; get; }
		[Column(TypeName = "varchar")]
		[StringLength(255)]
		public string SeoAlias { set; get; }
		[StringLength(255)]
		public string SeoKeywords { set; get; }
		[StringLength(255)]
		public string SeoDescription { set; get; }
	}
}
