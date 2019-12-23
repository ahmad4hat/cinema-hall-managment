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
            if (title == "") { throw new Exception("title can't be empty "); }
            if (releaseDate == "") { throw new Exception("releaseDate can't be empty "); }
            if (description == "") { throw new Exception("description can't be empty "); }
            if (duration == "") { throw new Exception("duration can't be empty "); }
            if (genre == "") { throw new Exception("genre can't be empty "); }
            if (director == "") { throw new Exception("director can't be empty "); }
            if (rating == "") { throw new Exception("rating can't be empty "); }



            Models.Movie movie = new Models.Movie(title, releaseDate, description, duration, genre, director, rating);
            try
            {
                dbC.addMovie(movie);
            }
            catch (Exception err) {

                throw err;
            }
        }

        public void removeMovie(String id){
             if (id == "") { throw new Exception("id can't be empty "); }


            try
            {
                dbC.removeMovie(Int32.Parse(id));
            }
            catch(Exception err)
            {
                throw err;
            }
        }

        public Models.Movie findMovie(String id)
        {
            if (id == "") { throw new Exception("id can't be empty "); }


            try
            {
                return dbC.findMovie(Int32.Parse(id));
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public void updateMovie(int id, String title, String releaseDate, String description, String duration, String genre, String director, String rating)
        {
            if (title == "") { throw new Exception("title can't be empty "); }
            if (releaseDate == "") { throw new Exception("releaseDate can't be empty "); }
            if (description == "") { throw new Exception("description can't be empty "); }
            if (duration == "") { throw new Exception("duration can't be empty "); }
            if (genre == "") { throw new Exception("genre can't be empty "); }
            if (director == "") { throw new Exception("director can't be empty "); }
            if (rating == "") { throw new Exception("rating can't be empty "); }

            Models.Movie movie = new Models.Movie(id,title, releaseDate, description, duration, genre, director, rating);

            dbC.updateMovie(movie);
        }

    }
}
