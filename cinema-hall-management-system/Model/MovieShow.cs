using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cinema_hall_management_system.Model
{
    class MovieShow
    {
        public int id { get; set; }
        public int movieId { get; set; }
        public int cinemahallId { get; set; }
        public int remainingCapacity { get; set; }
        public DateTime time { get; set; }

        public MovieShow() { }

        public MovieShow( int movieId, int cinemahallId, DateTime time)
        {
            this.movieId = movieId;
            this.cinemahallId = cinemahallId;
            
            this.time = time;
        }

        public MovieShow(int id,int movieId,int cinemahallId ,int remainingCapacity, DateTime time) {

            this.id = id;
            this.movieId = movieId;
            this.cinemahallId = cinemahallId;
            this.remainingCapacity =remainingCapacity ;
            this.time = time;
        }



        public String toString()
        {
            Console.WriteLine(" " + id + " " + movieId + " " + cinemahallId + " " + remainingCapacity + " " + time.ToString());
            return " " + id + " " + movieId + " " + cinemahallId + " " + remainingCapacity + " " + time.ToString();

        }


    }
}
