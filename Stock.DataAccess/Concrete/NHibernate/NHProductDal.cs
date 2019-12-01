using Stock.DataAccess.Abstract;
using Stock.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.DataAccess.Concrete.NHibernate
{
    public class NhProductDal : IProductDal
    {
        public void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            List<Product> products = new List<Product>
            {
                new Product{
                Id = 1,
                Name = "Deneme",
                Brand = "Sony",
                Model = "A960",
                Type = 1,
                WorkType = 1,
                Warranty = 3,
                Price = 3000,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now
                }
            };
            
            return products;
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
