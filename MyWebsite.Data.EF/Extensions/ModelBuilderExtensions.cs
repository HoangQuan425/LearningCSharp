﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MyWebsite.Data.EF.Extensions
{
	public static class ModelBuilderExtensions
	{
		public static void AddConfiguration<TEntity>(
			this ModelBuilder modelBuilder,
			DbEntityConfiguration<TEntity> entityConfiguration) where TEntity : class
		{
			modelBuilder.Entity<TEntity>(entityConfiguration.Configure);
		}
	}
	public abstract class DbEntityConfiguration<TEntity> where TEntity : class
	{
		public abstract void Configure(EntityTypeBuilder<TEntity> entity);
	}
}
