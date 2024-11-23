using MyWebsite.Core.Sharedkernel;
using MyWebsite.Data.Enums;
using MyWebsite.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebsite.Data.Entities
{
	public class Page : DomainEntity<int>, ISwitchable
	{
		[Required]
		[MaxLength(256)]
		public string Name { get; set; }
		[Required]
		[MaxLength(256)]
		public string Alias { get; set; }
		public string Content { get; set; }
		public Status Status { get; set; }
	}
}
