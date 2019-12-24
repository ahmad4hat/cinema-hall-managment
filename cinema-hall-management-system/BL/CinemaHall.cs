using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cinema_hall_management_system.DAL;
using Models = cinema_hall_management_system.Model;

namespace cinema_hall_management_system.BL
{
    class CinemaHall
    {
        DatabaseConnector dbC = new DatabaseConnector();
        public List<Models.CinemaHall> getCinemaHalls()
        {
            
            try
            {
                List<Models.CinemaHall> cinemaHalls = dbC.getCinemaHall();
                return cinemaHalls;
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public void addCinemaHall(String name, String capacity, String location)
        {
            if (name == "") { throw new Exception("name can't be empty "); }
            if (capacity == "") { throw new Exception("capacity can't be empty "); }
            if (location == "") { throw new Exception("location can't be empty "); }

            int cap;
            if(!int.TryParse( capacity  ,out cap))
            {
                 throw new Exception("capacity must be a number"); 
            }



            Models.CinemaHall cinemaHall = new Models.CinemaHall(name,cap,location);
            try
            {
                dbC.addCinemaHall(cinemaHall);
            }
            catch (Exception err)
            {

                throw err;
            }
        }


        public Models.CinemaHall findCinemaHall(String id)
        {
            if (id == "") { throw new Exception("id can't be empty "); }

            int idInt;
            if (!int.TryParse(id, out idInt))
            {
                throw new Exception("ID must be a number");
            }

            try
            {
                return dbC.findCinemaHall(idInt);
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public void removeCinemaHall (String id)
        {
            if (id == "") { throw new Exception("id can't be empty "); }

            int idInt;
            if (!int.TryParse(id, out idInt))
            {
                throw new Exception("ID must be a number");
            }



            try
            {
                dbC.removeCinemahall(idInt);
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public void updateCinemaHall(int id, String name, int capacity, String location){
            if (name == "") { throw new Exception("name can't be empty "); }
            if (capacity.ToString() == "") { throw new Exception("capacity can't be empty "); }
            if (location == "") { throw new Exception("location can't be empty "); }

            dbC.updateCinemaHall(new Model.CinemaHall(id, name, capacity, location));
        }
            
           

        }
}



