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
    public class GalleryServices : IGallery
    {
        private readonly EGShopContext _Context;
        public GalleryServices(EGShopContext context)
        {
            _Context = context;
        }

        public bool CreateGallery(Gallery gallery)
        {
            try
            {
                _Context.Galleries.Add(gallery);
                _Context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteGallery(int id)
        {
            try
            {
                _Context.Galleries.Remove(GetGalleryById(id));
                _Context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public IEnumerable<Gallery> GetAllGallerys()
        {
            return _Context.Galleries;
        }

        public Gallery GetGalleryById(int id)
        {
            return _Context.Galleries.Find(id);
        }

        public bool UpdateGallery(Gallery gallery)
        {
            try
            {
                _Context.Galleries.Update(gallery);
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
