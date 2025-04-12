using EGShop.Core.Interfaces;
using EGShop.Datalayer.Context;
using EGShop.Datalayer.Entites;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EGShop.Core.Services
{
    public class CommentSrvices : IComment
    {
        private readonly EGShopContext _Context;
        public CommentSrvices(EGShopContext context)
        {
            _Context = context;
        }

        public bool CreateComment(Comment comment)
        {
            try
            {
                _Context.Comments.Add(comment);
                _Context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteComment(int id)
        {
            try
            {
                _Context.Comments.Remove(GetCommentById(id));
                _Context.SaveChanges(); 
                return true;
            }
            catch
            {
                return false;
            }
        }

        public IEnumerable<Comment> GetAllComments()
        {
            return _Context.Comments;
        }

        public Comment GetCommentById(int id)
        {
            return _Context.Comments.Find(id);
        }

        public bool UpdateComment(Comment comment)
        {
            try
            {
                _Context.Comments.Update(comment);
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
