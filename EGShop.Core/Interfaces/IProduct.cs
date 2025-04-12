using EGShop.Datalayer.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EGShop.Core.Interfaces
{
    public interface IProduct
    {
        bool CreateProduct(Product product);
        bool UpdateProduct(Product product);
        bool DeleteProduct(int id);
        IEnumerable<Product> GetAllProducts();
        Product GetProductById(int id);
    }
}