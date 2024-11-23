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
	public class FooterConfiguration : DbEntityConfiguration<Footer>
	{
		public override void Configure(EntityTypeBuilder<Footer> entity)
		{
			entity.HasKey(c => c.Id);
			entity.Property(c => c.Id).HasMaxLength(255)
					.IsUnicode(false).HasMaxLength(255).IsRequired();
		}
	}
}
