using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EGShop.Datalayer.Entites
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string CommentMessage { get; set; }
        public DateTime CommentDate { get; set; }
        public int? SenderId { get; set; }
        #region Relations
        public User? Sender { get; set; }
        public Product Product { get; set; }
        #endregion

    }
}
