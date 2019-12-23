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
    }
}
