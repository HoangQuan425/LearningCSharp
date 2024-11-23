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
	[Table("ProductCategories")]
	public class ProductCategory : DomainEntity<int>, 
		IHasSeoMetaData, ISwitchable, ISortable, IDateChecking
	{
		[Required]
		[StringLength(25)]
		public string Name { get; set; }
		[StringLength(500)]
		public string Description { get; set; }
		public int? ParentId { get; set; }
		public int? HomeOrder { get; set; }
		[StringLength(255)]
		public string Image { get; set; }
		public bool? HomeFlag { get; set; }

		public DateTime DateCreated { get; set; }
		public DateTime DateModified { get; set; }
		int ISortable.SortOrder { get; set; }
		Status ISwitchable.Status { get; set; }
		[StringLength(255)]
		string IHasSeoMetaData.SeoPageTittle { get; set; }
		[Column(TypeName ="varchar")]
		[StringLength(255)]
		string IHasSeoMetaData.SeoAlias { get; set; }
		[StringLength(255)]
		string IHasSeoMetaData.SeoKeywords { get; set; }
		[StringLength(255)]
		string IHasSeoMetaData.SeoDescription { get; set; }

		

		public virtual ICollection<Product> Products { set;  get; }
		public ProductCategory()
		{
			Products = new List<Product>();
		}
	}
}
