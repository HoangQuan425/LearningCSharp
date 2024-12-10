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
	public class AdvertisementPageConfiguration : DbEntityConfiguration<AdvertisementPage>
	{
		public override void Configure(EntityTypeBuilder<AdvertisementPage> entity)
		{
			entity.Property(c => c.Id).HasMaxLength(20).IsRequired();
		}
	}
}
