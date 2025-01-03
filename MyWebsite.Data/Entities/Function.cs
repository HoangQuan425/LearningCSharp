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
	[Table("Functions")]
	public class Function : DomainEntity<string>, ISwitchable, ISortable
	{
		[Required]
		[StringLength(128)]
		public string Name { set; get; }

		[Required]
		[StringLength(250)]
		public string URL { set; get; }


		[StringLength(128)]
		public string ParentId { set; get; }

		public string IconCss { get; set; }
		public int SortOrder { set; get; }
		public Status Status { set; get; }

		public Function() { }

		public Function(string name, string url, string parentId, string iconCss, int sortOrder)
		{
			this.Name = name;
			this.URL = url;
			this.ParentId = parentId;
			this.IconCss = iconCss;
			this.SortOrder = sortOrder;
			this.Status = Status.Active;
		}
	}
}
