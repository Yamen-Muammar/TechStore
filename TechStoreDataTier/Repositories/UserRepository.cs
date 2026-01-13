using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechStoreApp_Core_.Models;
using TechStoreDataTier.Interfaces;

namespace TechStoreDataTier.Repositories
{
    internal class UserRepository : IUserRepository
    {
        // Insert
        public int Add(User user)
        {
            throw new NotImplementedException();
        }
        
        // Delete
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        //Gets

        public User Login(string email,string hasedPassword)
        {
            throw new NotImplementedException();
        }
        public List<User> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public User GetUserById(int id)
        {
            throw new NotImplementedException();
        }

        public bool IsUserExists(string email)
        {
            throw new NotImplementedException();
        }

        //Update
        public bool Update(User user)
        {
            throw new NotImplementedException();
        }
    }
}
