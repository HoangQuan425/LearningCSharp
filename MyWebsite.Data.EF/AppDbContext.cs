using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.IdentityModel.Tokens;
using MyWebsite.Data.EF.Configuration;
using MyWebsite.Data.EF.Extensions;
using MyWebsite.Data.Entities;
using MyWebsite.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebsite.Data.EF
{
	public class AppDbContext : IdentityDbContext<AppUser, AppRole, Guid>
	{
		public AppDbContext(DbContextOptions options) : base(options)
		{
		}
		#region Table Database
		public DbSet<Language> Languages { set; get; }
		public DbSet<SystemConfig> SystemConfigs { get; set; }
		public DbSet<Function> Functions { get; set; }

		public DbSet<AppUser> AppUsers { get; set; }
		public DbSet<AppRole> AppRoles { get; set; }
		public DbSet<Anoucement> Anoucements { set; get; }
		public DbSet<AnoucementUser> AnoucementUsers { set; get; }

		public DbSet<Blog> Bills { set; get; }
		public DbSet<BillDetail> BillDetails { set; get; }
		public DbSet<Blog> Blogs { set; get; }
		public DbSet<BlogTag> BlogTags { set; get; }
		public DbSet<Color> Colors { set; get; }
		public DbSet<Contact> Contacts { set; get; }
		public DbSet<Feedback> Feedbacks { set; get; }
		public DbSet<Footer> Footers { set; get; }
		public DbSet<Page> Pages { set; get; }
		public DbSet<Product> Products { set; get; }
		public DbSet<ProductCategory> ProductCategories { set; get; }
		public DbSet<ProductImage> ProductImages { set; get; }
		public DbSet<ProductQuantity> ProductQuantities { set; get; }
		public DbSet<ProductTag> ProductTags { set; get; }

		public DbSet<Size> Sizes { set; get; }
		public DbSet<Slide> Slides { set; get; }

		public DbSet<Tag> Tags { set; get; }

		public DbSet<Permission> Permissions { get; set; }
		public DbSet<WholePrice> WholePrices { get; set; }

		public DbSet<AdvertisementPage> AdvertisementPages { get; set; }
		public DbSet<Advertisement> Advertisements { get; set; }
		public DbSet<AdvertisementPosition> AdvertisementPositions { get; set; }
		#endregion


		protected override void OnModelCreating(ModelBuilder builder)
		{
			#region Identity Config

			builder.Entity<IdentityUserClaim<Guid>>().ToTable("AppUserClaims").HasKey(x => x.Id);

			builder.Entity<IdentityRoleClaim<Guid>>().ToTable("AppRoleClaims")
					.HasKey(x => x.Id);

			builder.Entity<IdentityUserLogin<Guid>>().ToTable("AppUserLogins").HasKey(x => x.UserId);

			builder.Entity<IdentityUserRole<Guid>>().ToTable("AppUserRoles")
					.HasKey(x => new { x.RoleId, x.UserId });

			builder.Entity<IdentityUserToken<Guid>>().ToTable("AppUserTokens")
				 .HasKey(x => new { x.UserId });

			#endregion Identity Config

			builder.AddConfiguration(new TagConfiguration());
			builder.AddConfiguration(new BlogTagConfiguration());
			builder.AddConfiguration(new ContactConfiguration());
			builder.AddConfiguration(new FooterConfiguration());
			builder.AddConfiguration(new ProductTagConfiguration());
			builder.AddConfiguration(new SystemConfigConfiguration());
			builder.AddConfiguration(new AdvertistmentPositionConfiguration());
			builder.AddConfiguration(new FunctionConfiguration());
			base.OnModelCreating(builder);
		}

		public override int SaveChanges()
		{
			var modified = ChangeTracker.Entries().Where(e => e.State == EntityState.Modified || e.State == EntityState.Added);
			foreach(EntityEntry item in modified)
			{
				var changeOrAddedItem = item.Entity as IDateChecking;
				if(changeOrAddedItem != null)
				{
					if(item.State == EntityState.Added)
					{
						changeOrAddedItem.DateCreated = DateTime.Now;
					}
					changeOrAddedItem.DateModified = DateTime.Now;
				}
			}
			return base.SaveChanges();
		}
	}
}
