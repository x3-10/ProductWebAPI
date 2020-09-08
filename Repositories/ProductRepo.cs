using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductWebAPI.Interfaces;
using ProductWebAPI.Models;

namespace ProductWebAPI.Repositories
{


    public class ProductRepo : IProductRepo
    {
        private readonly AppDbContext _db;

        public ProductRepo(AppDbContext db)
        {
            _db = db;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            List<Product> listResult;
            listResult = _db.products.ToList<Product>();

            return listResult;
        }
        public Product GetProduct(int id)
        {
            Product product = new Product();
            product = _db.products.FirstOrDefault<Product>(x => x.productID == id);
            return product;
        }

        public Product InsertProduct(Product product)
        {
            _db.products.Add(product);
            _db.SaveChanges();
            return product;
        }

        public Product UpdateProduct(Product productWithChanges)
        {
            Product product = _db.products.FirstOrDefault(x => x.productID == productWithChanges.productID);
            if(product!= null)
            {

                //product.productID = productWithChanges.productID;
                product.productName = productWithChanges.productName;
                product.serving = productWithChanges.serving;
                product.package = productWithChanges.package;
                product.prices = productWithChanges.prices;
                product.qty = productWithChanges.qty;
                _db.products.Update(product);
                _db.SaveChanges();
            }
            return product;
        }

        public Product DeleteProduct(int id)
        {
            Product product = new Product();
            product = _db.products.FirstOrDefault<Product>(x => x.productID == id);

            if (product != null)
            {
                _db.products.Remove(product);
                _db.SaveChanges();
            }

            return product;
        }

        public IEnumerable<Product> GetAllProducts(int id)
        {
            throw new NotImplementedException();
        }
    }


}
