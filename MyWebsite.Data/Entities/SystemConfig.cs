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
	[Table("SystemConfigs")]
	public class SystemConfig : DomainEntity<string>, ISwitchable
	{
		[Required]
		[StringLength(128)]
		public string Name { get; set; }

		public string Value1 { get; set; }

		public int? Value2 { get; set; }

		public bool? Value3 { get; set; }

		public DateTime? Value4 { get; set; }

		public decimal? Value5 { get; set; }

		public Status Status { get; set; }
	}
}
