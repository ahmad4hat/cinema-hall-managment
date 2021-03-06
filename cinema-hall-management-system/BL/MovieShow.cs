﻿using System;
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

        public void removeMovieShow(String id)
        {
            if (id == "") { throw new Exception("id can't be empty "); }

            int idInt;
            if (!int.TryParse(id, out idInt))
            {
                throw new Exception("ID must be a number");
            }



            try
            {
                dbC.removeMovieShow(idInt);
            }
            catch (Exception err)
            {
                throw err;
            }
        }


        public void updateMovieShow(String id, String movieId, String cinemahallId, String remainingCapacity, DateTime time)
        {
            if (movieId == "") { throw new Exception("movie id can't be empty"); }
            if (cinemahallId == "") { throw new Exception("cinemallID id can't be empty"); }

            int mid;
            int cid;
            int capacity;
            if (!int.TryParse(movieId, out mid))
            {
                throw new Exception("Movie ID must be a number");
            }

            if (!int.TryParse(cinemahallId, out cid))
            {
                throw new Exception("CinemaHall ID must be a number");
            }

            if (!int.TryParse(remainingCapacity, out capacity))
            {
                throw new Exception("CinemaHall ID must be a number");
            }

            try
            {
                dbC.updateMovieShow(new Model.MovieShow(int.Parse(id) , mid, cid, capacity, time));
            }catch(Exception err)
            {
                throw err;
            }


        }

        public Model.MovieShow findMovieShow(String id)
        {
            if (id == "") { throw new Exception("id can't be empty "); }

            int idInt;
            if (!int.TryParse(id, out idInt))
            {
                throw new Exception("ID must be a number");
            }

            try
            {
                return dbC.findMovieShow(idInt);
            }
            catch (Exception err)
            {
                throw err;
            }
        }


    }
}
