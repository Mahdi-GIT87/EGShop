using EGShop.Core.Interfaces;
using EGShop.Datalayer.Context;
using EGShop.Datalayer.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EGShop.Core.Services
{
    
    public class ProductServices : IProduct
    {
        private readonly EGShopContext _Context;

        public ProductServices(EGShopContext context) 
        {
            _Context = context;
        }
        public bool CreateProduct(Product product)
        {
            try
            {
                _Context.Products.Add(product);
                _Context.SaveChanges();
                return true;
            }
            catch 
            {
                return false;
            }
        }

        public bool DeleteProduct(int id)
        {
            try
            {
                _Context.Products.Remove(GetProductById(id));
                _Context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _Context.Products;
        }

        public Product GetProductById(int id)
        {
            return _Context.Products.Find(id);
        }

        public bool UpdateProduct(Product product)
        {
            try
            {
                _Context.Products.Update(product);
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
