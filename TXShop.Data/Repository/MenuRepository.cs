using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TXShop.Data.Infrastructure;
using TXShop.Model.Models;

namespace TXShop.Data.Repository
{
    public interface IMenuRepository
    {
    }
     public class MenuRepository: RepositoryBase<Menu>, IMenuRepository{
        public MenuRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }

    }
}
