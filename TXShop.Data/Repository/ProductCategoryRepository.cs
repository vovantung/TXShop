using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TXShop.Data.Infrastructure;
using TXShop.Model.Models;

namespace TXShop.Data.Repository
{
    public interface IProductCategoryRepository
    {

    }
    public class ProductCategoryRepository:RepositoryBase<ProductCategory>, IProductCategoryRepository
    {
        public ProductCategoryRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }

    }
}