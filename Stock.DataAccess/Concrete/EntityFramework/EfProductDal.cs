using Stock.DataAccess.Abstract;
using Stock.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal: IProductDal
    {
        public List<Product> GetAll()
        {
            using (StockContext context = new StockContext())
            {
                return context.Products.ToList();
            }
        }

        public Product Get(int id)
        {
            using (StockContext context = new StockContext())
            {
                return context.Products.SingleOrDefault(p => p.Id == id);
            }
        }

        public void Add(Product product)
        {
            using (StockContext context = new StockContext())
            {
                context.Products.Add(product);
                context.SaveChanges();
            }
        }

        public void Update(Product product)
        {
            using (StockContext context = new StockContext())
            {
                //context.Products.Add(product);
                context.SaveChanges();
            }
        }

        public void Delete(Product product)
        {
            using (StockContext context = new StockContext())
            {
                //context.Products.Add(product);
                context.SaveChanges();
            }
        }
    }
}
