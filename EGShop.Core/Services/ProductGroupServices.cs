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
    public class ProductGroupServices : IProductGroup
    {
        private readonly EGShopContext _Context;
        public ProductGroupServices(EGShopContext context)
        {
            _Context = context;
        }

        public bool CreateProductGroup(ProductGroup productGroup)
        {
            try
            {
                _Context.ProductGroups.Add(productGroup);
                _Context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteProductGroup(int id)
        {
            try
            {
                _Context.ProductGroups.Remove(GetProductGroupById(id));
                _Context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public IEnumerable<ProductGroup> GetAllProductGroups()
        {
            return _Context.ProductGroups;
        }

        public ProductGroup GetProductGroupById(int id)
        {
            return _Context.ProductGroups.Find(id);
        }

        public bool UpdateProductGroup(ProductGroup productGroup)
        {
            try
            {
                _Context.ProductGroups.Update(productGroup);
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
