﻿using MyWebsite.Core.Sharedkernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebsite.Data.Entities
{
	[Table("ProductTags")]
	public class ProductTag : DomainEntity<int>
	{
		public int ProductId { get; set; }
		[StringLength(50)]
		[Column(TypeName = "varchar")]
		public string TagId { get; set; }
		[ForeignKey("ProductId")]
		public virtual Product Product { get; set; }
		[ForeignKey("TagId")]
		public virtual Tag Tag { get; }
	}
}
