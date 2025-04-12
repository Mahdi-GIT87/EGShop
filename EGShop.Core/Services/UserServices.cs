using EGShop.Core.Interfaces;
using EGShop.Datalayer.Context;
using EGShop.Datalayer.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace EGShop.Core.Services
{
    public class UserServices : IUser
    {
        private readonly EGShopContext _Context;
        public UserServices(EGShopContext context)
        {
            _Context = context;
        }
        public bool CreateUser(User user)
        {
            try
            {
                _Context.Users.Add(user);
                _Context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteUser(int id)
        {
            try
            {
                _Context.Users.Remove(GetUserById(id));
                _Context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _Context.Users;
        }

        public User GetUserById(int id)
        {
            return _Context.Users.Find(id);
        }

        public bool UpdateUser(User user)
        {
            try
            {
                _Context.Users.Update(user);
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
