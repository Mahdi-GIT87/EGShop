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
    public class CartServices : ICart
    {
        private readonly EGShopContext _Context;
        public CartServices(EGShopContext context)
        {
            _Context = context;
        }
        public bool CreateCart(Cart cart)
        {
            try
            {
                _Context.Carts.Add(cart);
                _Context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteCart(int id)
        {
            try
            {
                _Context.Carts.Remove(GetCartById(id));
                _Context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public IEnumerable<Cart> GetAllCarts()
        {
            return _Context.Carts;
        }

        public Cart GetCartById(int id)
        {
            return _Context.Carts.Find(id);
        }

        public bool UpdateCart(Cart cart)
        {
            try
            {
                _Context.Carts.Update(cart);
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
