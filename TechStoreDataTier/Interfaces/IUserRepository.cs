using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechStoreApp_Core_;
using TechStoreApp_Core_.Models;

namespace TechStoreDataTier.Interfaces
{
    public interface IUserRepository
    {
        User GetUserById (int id);
        List<User> GetAllUsers();
        User Login(string email, string hasedPassword);
        bool IsUserExists(string email);
        int Add(User user);

        bool Update(User user);

        bool Delete(int id);
       
    }
}
