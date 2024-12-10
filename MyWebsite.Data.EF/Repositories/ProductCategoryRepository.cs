using MyWebsite.Data.Entities;
using MyWebsite.Data.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebsite.Data.EF.Repositories
{
	public class ProductCategoryRepository : EFRepository<ProductCategory, int>, IProductCategoryRepository
	{
		AppDbContext _context;
		public ProductCategoryRepository(AppDbContext context) : base(context)
		{
		}
	}
}
