﻿using MyWebsite.Core.Sharedkernel;
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
		public Product()
		{
			ProductTags = new List<ProductTag>();
		}

		public Product(string name, int categoryId, string thumbnailImage,
				decimal price, decimal originalPrice, decimal? promotionPrice,
				string description, string content, bool? homeFlag, bool? hotFlag,
				string tags, string unit, Status status, string seoPageTitle,
				string seoAlias, string seoMetaKeyword,
				string seoMetaDescription)
		{
			Name = name;
			CategoryId = categoryId;
			Image = thumbnailImage;
			Price = price;
			OriginalPrice = originalPrice;
			PromotionPrice = promotionPrice;
			Description = description;
			Content = content;
			HomeFlag = homeFlag;
			HotFlag = hotFlag;
			Tags = tags;
			Unit = unit;
			Status = status;
			SeoPageTitle = seoPageTitle;
			SeoAlias = seoAlias;
			SeoKeywords = seoMetaKeyword;
			SeoDescription = seoMetaDescription;
			ProductTags = new List<ProductTag>();

		}

		public Product(int id, string name, int categoryId, string thumbnailImage,
				 decimal price, decimal originalPrice, decimal? promotionPrice,
				 string description, string content, bool? homeFlag, bool? hotFlag,
				 string tags, string unit, Status status, string seoPageTitle,
				 string seoAlias, string seoMetaKeyword,
				 string seoMetaDescription)
		{
			Id = id;
			Name = name;
			CategoryId = categoryId;
			Image = thumbnailImage;
			Price = price;
			OriginalPrice = originalPrice;
			PromotionPrice = promotionPrice;
			Description = description;
			Content = content;
			HomeFlag = homeFlag;
			HotFlag = hotFlag;
			Tags = tags;
			Unit = unit;
			Status = status;
			SeoPageTitle = seoPageTitle;
			SeoAlias = seoAlias;
			SeoKeywords = seoMetaKeyword;
			SeoDescription = seoMetaDescription;
			ProductTags = new List<ProductTag>();

		}
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
		public decimal? PromotionPrice { get; set; }
		public decimal OriginalPrice { set; get; }
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
		public virtual ICollection<ProductTag> ProductTags { set; get; }

		public DateTime DateCreated { set; get; }
		public DateTime DateModified { set; get; }
		public int SortOrder { set; get; }
		public Status Status { set; get; }
		public string SeoPageTitle { set; get; }
		[Column(TypeName = "varchar")]
		[StringLength(255)]
		public string SeoAlias { set; get; }
		[StringLength(255)]
		public string SeoKeywords { set; get; }
		[StringLength(255)]
		public string SeoDescription { set; get; }
	}
}
