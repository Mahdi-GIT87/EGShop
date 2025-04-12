using EGShop.Datalayer.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EGShop.Core.Interfaces
{
    public interface IProductCart
    {
        bool CreateProductCart(ProductCart productCart);
        bool UpdateProductCart(ProductCart productCart);
        bool DeleteProductCart(int id);
        IEnumerable<ProductCart> GetAllProductCarts();
        ProductCart GetProductCartById(int id);
    }
}
