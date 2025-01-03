﻿using MyWebsite.Core.Sharedkernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MyWebsite.Data.Entities
{
	[Table("Permissions")]
	public class Permission : DomainEntity<int>
	{
		[Required]
		public Guid RoleId { get; set; }

		[StringLength(128)]
		[Required]
		public string FunctionId { get; set; }

		public bool CanCreate { set; get; }
		public bool CanRead { set; get; }

		public bool CanUpdate { set; get; }
		public bool CanDelete { set; get; }
		[ForeignKey("RoleId")]
		public virtual AppRole AppRole { get; set; }

		[ForeignKey("FunctionId")]
		public virtual Function Function { get; set; }
	}
}
