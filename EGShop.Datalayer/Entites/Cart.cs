using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EGShop.Datalayer.Entites
{
    public class Cart
    {
        public int CartId { get; set; }
        public int ProductCartId { get; set; }
        public bool IsDeleted { get; set; }
        #region Relations
        public ICollection<ProductCart> productCarts { get; set; }
        #endregion
    }
}
