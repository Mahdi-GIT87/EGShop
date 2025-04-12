using EGShop.Datalayer.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EGShop.Core.Interfaces
{
    public interface IComment
    {
        bool CreateComment(Comment comment);
        bool UpdateComment(Comment comment);
        bool DeleteComment(int id);
        IEnumerable<Comment> GetAllComments();
        Comment GetCommentById(int id);
    }
}
