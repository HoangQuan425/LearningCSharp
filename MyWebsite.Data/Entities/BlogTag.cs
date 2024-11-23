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
	[Table("BlogTags")]
	public class BlogTag : DomainEntity<int>
	{
		public int BlogId {  get; set; }
		[ForeignKey("BlogId")]
		public virtual Blog Blog { get; set; }
		[StringLength(50)]
		[Column(TypeName = "varchar")]
		public string TagId { get; set; }
		[ForeignKey("TagId")]
		public virtual Tag Tag { get; }
	}
}
