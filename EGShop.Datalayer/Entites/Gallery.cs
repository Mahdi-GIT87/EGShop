using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EGShop.Datalayer.Entites
{
    public class Gallery
    {
        public int GalleryId { get; set; }
        public string ImageName { get; set; }
        public bool IsDeleted { get; set; }
        public int ProductId { get; set; }
        #region Relations
        public Product product { get; set; }
        #endregion
    }
}
