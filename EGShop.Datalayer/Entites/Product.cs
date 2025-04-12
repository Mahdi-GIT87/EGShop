using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EGShop.Datalayer.Entites
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int Views { get; set; }
        public int SellCount { get; set; }
        public DateTimeOffset PublishDate { get; set; }
        public bool IdExists { get; set; }
        public bool IdDeleted { get; set; }
        public bool IsPublished { get; set; }
        public string Thumbnail { get; set; }
        public Double Price { get; set; }
        public int? UserId { get; set; }

        #region Relation
        public ProductGroup ProductGroup { get; set; }
        public ICollection<Gallery> Galleries { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Question> Questions { get; set; }
        public User Seller { get; set; }
        #endregion

    }
}
