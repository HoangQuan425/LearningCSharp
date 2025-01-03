﻿using MyWebsite.Core.Sharedkernel;
using MyWebsite.Data.Enums;
using MyWebsite.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebsite.Data.Entities
{
	[Table("Languages")]
	public class Language : DomainEntity<string>, ISwitchable
	{
		[Required]
		[StringLength(128)]
		public string Name { get; set; }

		public bool IsDefault { get; set; }

		public string Resources { get; set; }

		public Status Status { get; set; }
	}
}
