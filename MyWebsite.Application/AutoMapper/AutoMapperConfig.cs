using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebsite.Application.AutoMapper
{
	public static class AutoMapperConfig 
	{
		public static void RegisterMappings(IServiceCollection services)
		{
			var mapperConfig = new MapperConfiguration(cfg =>
			{
				cfg.AddProfile<ProductCategoryMappingProfile>();
				cfg.AddProfile<ProductMappingProfile>();
			});

			// Kiểm tra cấu hình ánh xạ
			mapperConfig.AssertConfigurationIsValid();

			var mapper = mapperConfig.CreateMapper();
			services.AddScoped<IMapper>(provider => mapper);
		}
	}
}
