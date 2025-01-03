﻿using MyWebsite.Application.Interfaces.Product.Dto;
using MyWebsite.Data.Entities;
using MyWebsite.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebsite.Application.Interfaces.ProductCategory.Dto
{
	public class ProductCategoryDto
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public string Description { get; set; }

		public int? ParentId { get; set; }

		public int? HomeOrder { get; set; }

		public string Image { get; set; }

		public bool? HomeFlag { get; set; }

		public DateTime DateCreated { set; get; }
		public DateTime DateModified { set; get; }
		public int SortOrder { set; get; }
		public Status Status { set; get; }
		public string SeoPageTitle { set; get; }
		public string SeoAlias { set; get; }
		public string SeoKeywords { set; get; }
		public string SeoDescription { set; get; }

		public ICollection<ProductDto> Products { set; get; }
	}
}
