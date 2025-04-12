using EGShop.Core.Interfaces;
using EGShop.Datalayer.Context;
using EGShop.Datalayer.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EGShop.Core.Services
{
    public class ProductCartServices : IProductCart
    {
        private readonly EGShopContext _Context;
        public ProductCartServices(EGShopContext context)
        {
            _Context = context;
        }

        public bool CreateProductCart(ProductCart productCart)
        {
            try
            {
                _Context.ProductCarts.Add(productCart);
                _Context.SaveChanges();
                return true;
            }
            catch 
            {
                return false;
            }
        }

        public bool DeleteProductCart(int id)
        {
            try
            {
                _Context.ProductCarts.Remove(GetProductCartById(id));
                _Context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public IEnumerable<ProductCart> GetAllProductCarts()
        {
            return _Context.ProductCarts;
        }

        public ProductCart GetProductCartById(int id)
        {
            return _Context.ProductCarts.Find(id);
        }

        public bool UpdateProductCart(ProductCart productCart)
        {
            try
            {
                _Context.ProductCarts.Update(productCart);
                _Context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
