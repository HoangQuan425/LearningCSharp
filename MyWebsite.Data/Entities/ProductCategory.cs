﻿using MyWebsite.Core.Sharedkernel;
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

		public virtual ICollection<Product> Products { set; get; }
		public ProductCategory()
		{
			Products = new List<Product>();
		}
	}
}
