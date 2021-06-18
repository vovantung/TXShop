using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TXShop.Data.Infrastructure
{
    public class UnitOfWork:IUintOfWork
    {
        private readonly IDbFactory dbFactory;
        private TXShopDbContext dbContext;
        public UnitOfWork(IDbFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }
        public TXShopDbContext DbContext
        {
            get { return dbContext ?? (dbContext = dbFactory.Init()); }
        }
        public  void Commit()
        {
            DbContext.SaveChanges();
        }

    }
}
