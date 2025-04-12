using EGShop.Datalayer.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EGShop.Core.Interfaces
{
    public interface IGallery
    {
        bool CreateGallery(Gallery gallery);
        bool UpdateGallery(Gallery gallery);
        bool DeleteGallery(int id);
        IEnumerable<Gallery> GetAllGallerys();
        Gallery GetGalleryById(int id);
    }
}
