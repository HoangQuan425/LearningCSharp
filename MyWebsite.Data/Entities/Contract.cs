﻿using MyWebsite.Core.Sharedkernel;
using MyWebsite.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebsite.Data.Entities
{
	[Table("ContactDetails")]
	public class Contact : DomainEntity<string>
	{
		[StringLength(250)]
		[Required]
		public string Name { set; get; }

		[StringLength(50)]
		public string Phone { set; get; }

		[StringLength(250)]
		public string Email { set; get; }

		[StringLength(250)]
		public string Website { set; get; }

		[StringLength(250)]
		public string Address { set; get; }

		public string Other { set; get; }

		public double? Lat { set; get; }

		public double? Lng { set; get; }

		public Status Status { set; get; }
	}
}
