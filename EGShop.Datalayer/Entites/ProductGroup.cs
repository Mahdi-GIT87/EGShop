using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EGShop.Datalayer.Entites
{
    public class ProductGroup
    {
        public int ProductGroupId { get; set; }
        public string ProductGroupName { get; set; }
        public string ProductGroupImage { get; set; }
        public bool IsDeleted { get; set; }

        #region Relations
        public ICollection<Product> Products { get; set; }
        #endregion
    }
}
