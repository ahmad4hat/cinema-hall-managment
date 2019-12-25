using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace cinema_hall_management_system.BL
{
    class MovieShow
    {
        DAL.DatabaseConnector dbC = new DAL.DatabaseConnector();

        public List<Model.MovieShow> GetMovieShows()
        {
            try
            {
                return dbC.GetMovieShows();
            }catch (Exception err)
            {
                throw err;
            }
        }

        public void addMovieShow(String movieId, String cinemahallId, DateTime time)
        {
            if (movieId == "") { throw new Exception("movie id can't be empty"); }
            if (cinemahallId == "") { throw new Exception("cinemallID id can't be empty"); }

            int mid;
            int cid;
            if (!int.TryParse(movieId, out mid))
            {
                throw new Exception("Movie ID must be a number");
            }

            if (!int.TryParse(cinemahallId, out cid))
            {
                throw new Exception("CinemaHall ID must be a number");
            }

            try
            {
                Model.MovieShow movieShow = new Model.MovieShow(mid, cid, time);

                dbC.addMovieShow(movieShow);

            }
            catch(Exception err)
            {
                throw err;
            }
        }
    }
}
