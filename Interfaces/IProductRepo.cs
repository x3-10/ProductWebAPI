
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductWebAPI.Models;

namespace ProductWebAPI.Interfaces
{
    public interface IProductRepo
    {
        IEnumerable<Product> GetAllProducts();

        Product GetProduct(int id);

        Product InsertProduct(Product product);
        Product UpdateProduct(Product productWithChanges);
        Product DeleteProduct(int id);
        
    }
}
