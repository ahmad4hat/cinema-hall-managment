using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cinema_hall_management_system.Model
{
    class CinemaHall
    {
        public int id { get; set; }
        public String name { get; set; }
        public int capacity { get; set; }

        public String location { get; set; }

        public CinemaHall()
        {

        }
        public CinemaHall(int id, String name, int capacity, String location)
        {
            this.id = id;
            this.name = name;
            this.capacity = capacity;
            this.location = location;
        }
        public CinemaHall( String name, int capacity, String location)
        {
            this.name = name;
            this.capacity = capacity;
            this.location = location;
        }

    }
}
