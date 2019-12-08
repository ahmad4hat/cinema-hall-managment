using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cinema_hall_management_system.Model
{
    class Movie
    {
        public int id { get; set; }
        public String title { get; set; }
        public String releaseDate { get; set; }
        public String description { get; set; }
        public String duration { get; set; }
        public String genre { get; set; }
        public String director { get; set; }
        public String rating { get; set; }

        public Movie() { }
        public Movie(int id, String title, String releaseDate, String description, String duration, String genre, String director,String rating)
        {
            this.id = id;
            this.description = description;
            this.duration = duration;
            this.genre = genre;
            this.title = title;
            this.director = director;
            this.releaseDate = releaseDate;
            this.rating = rating;

        }

        public Movie(String title, String releaseDate, String description, String duration, String genre, String director,String rating)
        {
            this.description = description;
            this.duration = duration;
            this.genre = genre;
            this.title = title;
            this.director = director;
            this.releaseDate = releaseDate;
            this.rating = rating;
        }

        public void showMovie()
        {
            Console.WriteLine("id ="+ this.id +", title="+ this.title +", releaseDate ="+this.releaseDate +", description="+ this.description + ",  duration=" + this.duration + ", genre=" + this.genre + ", director=" + this.director + ", rateing=" + this.rating);
        }
    }
}
