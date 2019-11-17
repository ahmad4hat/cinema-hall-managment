using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cinema_hall_management_system.Model
{
    class User
    {
        public String id { get; set; }
        public String email { get; set; }
        public String name { get; set; }

        public String dateOfBirth { get; set; }
        public String gender { get; set; }
        
        public String password { get; set; }
        public String address { get; set; }


        public User() { }

        public User(String email, String password, String name, String address, String dateOfBirth, String gender)
        {
            this.dateOfBirth = dateOfBirth;
            this.name = name;
            this.email = email;
            this.gender = gender;
            this.password = password;
            this.address = address;
        }
    }
}
