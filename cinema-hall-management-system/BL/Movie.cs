using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using cinema_hall_management_system.DAL;
using Models = cinema_hall_management_system.Model;

namespace cinema_hall_management_system.BL
{
    class Movie
    {
        DatabaseConnector dbC = new DatabaseConnector();
        
        public List<Models.Movie> getMovies()
        {
            try
            {
                List<Models.Movie> movies = dbC.getMovies();
                return movies;
            }
            catch(Exception e)
            {
                throw e;
            }
            
           
        }
        public void addMovie(String title, String releaseDate, String description, String duration, String genre, String director, String rating)
        {
            Models.Movie movie = new Models.Movie(title, releaseDate, description, duration, genre, director, rating);
            try
            {
                dbC.addMovie(movie);
            }
            catch (Exception err) {

                throw err;
            }
        }

    }
}
