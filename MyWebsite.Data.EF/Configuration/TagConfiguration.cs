using Microsoft.EntityFrameworkCore;
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
	public class TagConfiguration : DbEntityConfiguration<Tag>
	{
		public override void Configure(EntityTypeBuilder<Tag> entity)
		{
			entity.Property(c => c.Id).HasMaxLength(50).IsRequired().HasColumnType("varchar(50)");
		}
	}
}
