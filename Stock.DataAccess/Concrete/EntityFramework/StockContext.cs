using Stock.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.DataAccess.Concrete.EntityFramework
{
    public class StockContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
