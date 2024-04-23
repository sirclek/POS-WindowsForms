using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS
{
     public class Employee
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        public Employee(string id, string name, string email, string username, string password, string role)
        {
            ID = id;
            this.Name = name;
            this.Email = email;
            this.Username = username;
            this.Password = password;
            this.Role = role;
        }
    }
}
