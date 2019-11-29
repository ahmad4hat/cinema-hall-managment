using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cinema_hall_management_system.Model
{
    class Employee
    {
        public int id { get; set; }
        public String email { get; set; }
        public String name { get; set; }

        public String dateOfBirth { get; set; }
        public String gender { get; set; }
        public String role { get; set; }
        public String password { get; set; }
        public String address { get; set; }


        public Employee() { }

        public Employee(String email,String password,String name,String address, String dateOfBirth,String gender,String role) {
            this.dateOfBirth = dateOfBirth;
            this.name = name;
            this.role = role;
            this.email = email;
            this.gender = gender;
            this.password = password;
            this.address = address;
        }

        public Employee(int id,String email, String password, String name, String address, String dateOfBirth, String gender, String role)
        {
            this.id = id;
            this.dateOfBirth = dateOfBirth;
            this.name = name;
            this.role = role;
            this.email = email;
            this.gender = gender;
            this.password = password;
            this.address = address;
        }


    }
}
