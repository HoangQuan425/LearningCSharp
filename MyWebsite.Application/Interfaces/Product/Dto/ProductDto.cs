using MyWebsite.Data.Entities;
using MyWebsite.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyWebsite.Application.Interfaces.ProductCategory.Dto;

namespace MyWebsite.Application.Interfaces.Product.Dto
{
	public class ProductDto
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int CategoryId { get; set; }
		public ProductCategoryDto ProductCategory { get; set; }
		public string Image { get; set; }
		public decimal Price { get; set; }
		public decimal? PromotionPrice { get; set; }
		public decimal OriginalPrice { set; get; }
		public string Description { get; set; }
		public string Content { get; set; }
		public bool? HomeFlag { get; set; }
		public bool? HotFlag { get; set; }
		public int? ViewCount { get; set; }
		public string Tags { get; set; }
		public string Unit { get; set; }
		public virtual ICollection<ProductTag> ProductTags { set; get; }

		public DateTime DateCreated { set; get; }
		public DateTime DateModified { set; get; }
		public int SortOrder { set; get; }
		public Status Status { set; get; }
		public string SeoPageTitle { set; get; }
		public string SeoAlias { set; get; }
		public string SeoKeywords { set; get; }
		public string SeoDescription { set; get; }
	}
}
