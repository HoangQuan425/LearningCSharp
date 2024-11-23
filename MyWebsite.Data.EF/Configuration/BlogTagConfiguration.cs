using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyWebsite.Data.EF.Extensions;
using MyWebsite.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebsite.Data.EF.Configuration
{
	public class BlogTagConfiguration : DbEntityConfiguration<BlogTag>
	{
		public override void Configure(EntityTypeBuilder<BlogTag> entity)
		{
			entity.Property(c=>c.TagId).HasMaxLength(50).IsRequired().IsUnicode(false).HasMaxLength(50);
		}
	}
}
