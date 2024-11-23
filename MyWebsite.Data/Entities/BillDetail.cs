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
	[Table("BillDetails")]
	public class BillDetail : DomainEntity<long>
	{
		public long BillId { get; set; }
		[ForeignKey("BillId")]
		public virtual Bill Bill { get; set; }

		public int ProductId {  get; set; }
		[ForeignKey("ProductId")]
		public virtual Product Product { get; set; }

		public int Quantity {  get; set; }
		public decimal Price {  get; set; }

		public int ColorId { get; set; }

		public int SizeId { get; set; }
		[ForeignKey("ColorId")]
		public virtual Color Color { set; get; }

		[ForeignKey("SizeId")]
		public virtual Size Size { set; get; }
	}
}
