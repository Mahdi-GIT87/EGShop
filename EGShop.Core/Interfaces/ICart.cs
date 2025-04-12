using EGShop.Datalayer.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EGShop.Core.Interfaces
{
    public interface ICart
    {
        bool CreateCart(Cart cart);
        bool UpdateCart(Cart cart);
        bool DeleteCart(int id);
        IEnumerable<Cart> GetAllCarts();
        Cart GetCartById(int id);
    }
}
