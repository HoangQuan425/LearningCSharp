using AutoMapper;
using MyWebsite.Application.Interfaces.ProductCategory;
using MyWebsite.Application.Interfaces.ProductCategory.Dto;
using MyWebsite.Data.EF.Repositories;
using MyWebsite.Data.Entities;
using MyWebsite.Data.Interfaces;
using MyWebsite.Data.IRepositories;
using MyWebsite.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebsite.Application.Implementation
{
	public class ProductCategoryService : IProductCategoryService
	{
		private readonly IProductCategoryRepository _productCategoryRepository;
		private readonly IMapper _mapper;
		private IUnitOfWork _unitOfWork;

		public ProductCategoryService(IProductCategoryRepository productCategoryRepository, IMapper mapper, IUnitOfWork unitOfWork)
		{
			_productCategoryRepository = productCategoryRepository;
			_mapper = mapper;
			_unitOfWork = unitOfWork;
		}

		public async Task<ProductCategoryDto> Add(ProductCategoryDto productCategoryDto)
		{
			var productCategory = _mapper.Map<ProductCategory>(productCategoryDto);

			await _productCategoryRepository.AddAsync(productCategory);

			return _mapper.Map<ProductCategoryDto>(productCategory);
		}

		public async Task delete(int productCategoryId)
		{
			await _productCategoryRepository.RemoveAsync(productCategoryId);
		}

		public Task<List<ProductCategoryDto>> GetAll(ProductCategoryInput input)
		{
			throw new NotImplementedException();
		}

		public Task<List<ProductCategoryDto>> GetAllByParentId(int parentId)
		{
			throw new NotImplementedException();
		}

		public Task<ProductCategoryDto> GetById(int id)
		{
			throw new NotImplementedException();
		}

		public Task<List<ProductCategoryDto>> GetHomeCategories(int top)
		{
			throw new NotImplementedException();
		}

		public Task ReOrder(int sourceId, int targetId)
		{
			throw new NotImplementedException();
		}

		public Task Save()
		{
			throw new NotImplementedException();
		}

		public Task update(ProductCategoryDto productCategory)
		{
			throw new NotImplementedException();
		}

		public Task UpdateParentId(int sourceId, int targetId, Dictionary<int, int> items)
		{
			throw new NotImplementedException();
		}
	}
}
