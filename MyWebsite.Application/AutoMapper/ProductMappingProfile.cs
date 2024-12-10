using AutoMapper;
using MyWebsite.Application.Interfaces.Product.Dto;
using MyWebsite.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebsite.Application.AutoMapper
{
	public class ProductMappingProfile : Profile
	{
		public ProductMappingProfile() {
			CreateMap<Product, ProductDto>();
		}
	}
}
