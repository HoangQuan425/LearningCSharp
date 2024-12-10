using MyWebsite.Data.Entities;
using MyWebsite.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebsite.Data.IRepositories
{
    public interface IProductCategoryRepository : IRepository<ProductCategory, int>
    {
    }
}
