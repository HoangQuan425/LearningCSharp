using MyWebsite.Core.Sharedkernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebsite.Data.Entities
{
	[Table("Sizes")]
	public class Size : DomainEntity<int>
	{

		[StringLength(250)]
		public string Name
		{
			get; set;
		}
	}
}
