using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechStoreApp_Core_.Models
{
    public class User
    {
        public int? Id { get;}
        public string  FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string HashedPassword { get; set; }
        public string PhoneNumber { get; set; }
        public int Permission { get; set; }

        public User(int? id, string firstName, string lastName, string phoneNumber, string email, string hashedPassword, int permission)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            HashedPassword = hashedPassword;
            PhoneNumber = phoneNumber;
            Permission = permission;            
        }


    }
}
