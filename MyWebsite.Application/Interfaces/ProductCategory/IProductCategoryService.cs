using MyWebsite.Application.Interfaces.Product.Dto;
using MyWebsite.Application.Interfaces.ProductCategory.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebsite.Application.Interfaces.ProductCategory
{
	public interface IProductCategoryService
	{
		Task<ProductCategoryDto> Add(ProductCategoryDto productCategoryDto);
		Task update(ProductCategoryDto productCategory);
		Task delete(int productCategoryId);
		//public List<ProductCategoryDto> GetAll();
		Task<List<ProductCategoryDto>> GetAll(ProductCategoryInput input);

		Task<List<ProductCategoryDto>> GetAllByParentId(int parentId);

		Task<ProductCategoryDto> GetById(int id);

		Task UpdateParentId(int sourceId, int targetId, Dictionary<int, int> items);
		Task ReOrder(int sourceId, int targetId);

		Task<List<ProductCategoryDto>> GetHomeCategories(int top);
		Task Save();
	}
}
