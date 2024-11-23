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
	public class FunctionConfiguration : DbEntityConfiguration<Function>
	{
		public override void Configure(EntityTypeBuilder<Function> entity)
		{
			entity.HasKey(c => c.Id);
			entity.Property(c => c.Id).IsRequired()
					.HasMaxLength(128).IsUnicode(false);
		}
	}
}
