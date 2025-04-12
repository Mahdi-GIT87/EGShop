using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EGShop.Datalayer.Entites
{
    public class ProductCart
    {
        public int ProductCartId { get; set; }
        public int ProductCount { get; set; }
        public int CartId { get; set; }
        public int ProductId { get; set; }

        public double TotalPrice
        {
            get
            {
                return Product.Price * ProductCount;
            }
        }
        #region Relations
        public Product Product { get; set; }
        public Cart Cart { get; set; }
        #endregion
    }
}
