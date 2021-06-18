using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TXShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        TXShopDbContext dbContext;
        public TXShopDbContext Init()
        {
            return dbContext ?? (dbContext = new TXShopDbContext());
        }
        protected override void DisposeCore()
        {
            if(dbContext != null)
            {
                dbContext.Dispose();

            }
        }



    }
}
