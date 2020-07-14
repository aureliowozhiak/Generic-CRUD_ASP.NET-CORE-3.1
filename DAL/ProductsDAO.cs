using Generic_CRUD_ASP.NET_CORE_3._1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Generic_CRUD_ASP.NET_CORE_3._1.DAL
{
    public class ProductsDAO
    {
        private readonly Context _context;
        public ProductsDAO(Context context)
        {
            _context = context;
        }

        public void Create(Product product)
        {
            _context.Add(product);
            _context.SaveChanges();
        }

        public List<Product> List()
        {
            return _context.Product.ToList();
        }
        public Product ListProduct(Guid id)
        {

            return _context.Product.Find(id);

        }
    }
}
