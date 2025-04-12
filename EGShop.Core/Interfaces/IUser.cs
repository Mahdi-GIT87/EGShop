using EGShop.Datalayer.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EGShop.Core.Interfaces
{
    public interface IUser
    {
        bool CreateUser(User user);
        bool UpdateUser(User user);
        bool DeleteUser(int id);
        IEnumerable<User> GetAllUsers();
        User GetUserById(int id);
    }
}
