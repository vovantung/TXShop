using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TXShop.Data.Infrastructure;
using TXShop.Model.Models;

namespace TXShop.Data.Repository
{
    public interface IOrderRepository
    {

    }
    public class OrderRepository: RepositoryBase<Order>, IOrderRepository { 
        public OrderRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
    
}
