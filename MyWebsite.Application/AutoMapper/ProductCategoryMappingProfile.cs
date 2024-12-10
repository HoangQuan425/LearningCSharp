using AutoMapper;
using MyWebsite.Application.Interfaces.ProductCategory.Dto;
using MyWebsite.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebsite.Application.AutoMapper
{
	public class ProductCategoryMappingProfile : Profile
	{
		public ProductCategoryMappingProfile()
		{
			CreateMap<ProductCategory, ProductCategoryDto>();
			CreateMap<ProductCategoryInput, ProductCategory>();
		}
	}
}
