using MyWebsite.Core.Sharedkernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebsite.Data.Entities
{
	[Table("ProductImages")]
	public class ProductImage : DomainEntity<long>
	{
		public int ProductId {  get; set; }
		[ForeignKey("ProductId")]
		public virtual Product Product { get; set; }
		[StringLength(250)]
		public string Path { get; set; }
		[StringLength(250)]
		public string Caption { get; set; }
	}
}
