using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models = cinema_hall_management_system.Model;
using Dal = cinema_hall_management_system.DAL;

namespace cinema_hall_management_system.BL
{
    class User
    {
        public void userAdd(String email, String password, String name, String address, String dateOfBirth, String gender)

        {
            Console.WriteLine(email);
            if (email == "")
            {
                throw new Exception("email is empty");
            }
            if (password == "")
            {
                throw new Exception("password is empty");
            }
            if (name == "")
            {
                throw new Exception("name is empty");
            }
            if (address == "")
            {
                throw new Exception("address is empty");
            }
            if (dateOfBirth == "")
            {
                throw new Exception("dateOfBirth is empty");
            }
            if (gender == "")
            {
                throw new Exception("gender is empty");
            }
    
            Models.User user = new Models.User(email, password, name, address, dateOfBirth, gender);
            Dal.DatabaseConnector connector = new Dal.DatabaseConnector();

            try
            {
                connector.addUser(user);
            }
            catch (Exception excp)
            {
                throw excp;
            }


        }
    }
}
