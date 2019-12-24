using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Models = cinema_hall_management_system.Model;

namespace cinema_hall_management_system.DAL
{
    class DatabaseConnector
    {
        String MysqlConnetionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=cinema_hall_management;";

        public bool empLoginTest(String email,String password)
        {
            

            String query = "SELECT * FROM `employee` WHERE email='" + email+"' and Password='"+password+"'" ;

            MySqlConnection databaseConnection = new MySqlConnection(MysqlConnetionString);
            MySqlCommand comandDatabase = new MySqlCommand(query, databaseConnection);

            comandDatabase.CommandTimeout = 60;
            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = comandDatabase.ExecuteReader();
                if(myReader.HasRows)
                {
                    Console.WriteLine("found");
                    return true;

                }
                else
                {
                    Console.WriteLine("not found");
                    return false;
                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("not found");
                return false;
            }

        }

        public void addEmployee(Models.Employee emp)
        {
            String query = "INSERT INTO `employee` (`id`, `email`, `password`, `dateOfBirth`, `address`, `role`, `gender`, `name`) VALUES (NULL, '"+emp.email+"', '"+emp.password+"', '"+emp.dateOfBirth+"', '"+emp.address+"', '"+emp.role+"', '"+emp.gender+"', '"+emp.name+"')";
            Console.WriteLine(query);

            MySqlConnection databaseConnection = new MySqlConnection(MysqlConnetionString);
            MySqlCommand comandDatabase = new MySqlCommand(query, databaseConnection);
            comandDatabase.CommandTimeout = 60;
            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = comandDatabase.ExecuteReader();
             
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public void addUser(Models.User user)
        {
            String query = "INSERT INTO `user` (`id`, `email`, `password`, `dateOfBirth`, `address`, `gender`, `name`) VALUES (NULL, '" + user.email + "', '" + user.password + "', '" + user.dateOfBirth + "', '" + user.address + "', '" + user.gender + "', '" + user.name + "')";
            Console.WriteLine(query);

            MySqlConnection databaseConnection = new MySqlConnection(MysqlConnetionString);
            MySqlCommand comandDatabase = new MySqlCommand(query, databaseConnection);
            comandDatabase.CommandTimeout = 60;
            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = comandDatabase.ExecuteReader();

            }
            catch (Exception e)
            {
                throw e;
            }

        }
        public bool userLoginTest(String email, String password)
        {


            String query = "SELECT * FROM `user` WHERE email='" + email + "' and Password='" + password + "'";

            MySqlConnection databaseConnection = new MySqlConnection(MysqlConnetionString);
            MySqlCommand comandDatabase = new MySqlCommand(query, databaseConnection);

            comandDatabase.CommandTimeout = 60;
            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = comandDatabase.ExecuteReader();
                if (myReader.HasRows)
                {
                    Console.WriteLine("found");
                    return true;

                }
                else
                {
                    Console.WriteLine("not found");
                    return false;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("not found");
                return false;
            }

        }

        public List<Models.Movie> getMovies()
        {
            List<Models.Movie> movies = new List<Models.Movie>();

            String query = "SELECT * FROM movie";

            MySqlConnection databaseConnection = new MySqlConnection(MysqlConnetionString);
            MySqlCommand comandDatabase = new MySqlCommand(query, databaseConnection);

            comandDatabase.CommandTimeout = 60;
            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = comandDatabase.ExecuteReader();
                if (myReader.HasRows)
                {
                    while (myReader.Read())
                    {
                        Models.Movie movie = new Models.Movie(int.Parse(myReader[0].ToString()), myReader[1].ToString(), myReader[2].ToString(), myReader[3].ToString(), myReader[4].ToString(), myReader[5].ToString(), myReader[6].ToString(), myReader[7].ToString());
                        //movie.showMovie();
                        movies.Add(movie);

                    }

                    return movies;
                }
                else
                {
                    return movies;
                   
                }

            }
            catch (Exception e)
            {
                throw e;
                
            }


            

        }

        public void addMovie(Models.Movie movie) {

            String query = "INSERT INTO `movie` (`id`, `title`, `releaseDate`, `description`, `duration`, `genre`, `director`, `rating`) VALUES (NULL, '" + movie.title + "', '" + movie.releaseDate + "', '" + movie.description + "', '" + movie.duration+ "', '"+movie.genre+"', '"+movie.director+"', '"+movie.rating+"')";
    
            MySqlConnection databaseConnection = new MySqlConnection(MysqlConnetionString);
            MySqlCommand comandDatabase = new MySqlCommand(query, databaseConnection);
            comandDatabase.CommandTimeout = 60;
            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = comandDatabase.ExecuteReader();

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void removeMovie(int id){
            String query = "DELETE FROM `movie` WHERE `movie`.`id` = "+id+";";
            MySqlConnection databaseConnection = new MySqlConnection(MysqlConnetionString);
            MySqlCommand comandDatabase = new MySqlCommand(query, databaseConnection);
            comandDatabase.CommandTimeout = 60;
            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = comandDatabase.ExecuteReader();

            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public Models.Movie findMovie(int id)
        {
            String query = "SELECT * FROM `movie` WHERE id = "+id;

            MySqlConnection databaseConnection = new MySqlConnection(MysqlConnetionString);
            MySqlCommand comandDatabase = new MySqlCommand(query, databaseConnection);

            comandDatabase.CommandTimeout = 60;
            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = comandDatabase.ExecuteReader();
                if (myReader.HasRows)
                {
                    if (myReader.Read())
                    {
                        Console.WriteLine("found");

                        Models.Movie movie = new Models.Movie(int.Parse(myReader[0].ToString()), myReader[1].ToString(), myReader[2].ToString(), myReader[3].ToString(), myReader[4].ToString(), myReader[5].ToString(), myReader[6].ToString(), myReader[7].ToString());

                        movie.showMovie();
                        return movie;
                    }

                    throw new Exception("Reader can't read");


                }
                else
                {
                    throw new Exception("movie not found");
                }

            }
            catch (Exception e)
            {
                throw e;
            }
        }


        public void updateMovie(Models.Movie movie)
        {
            String query = "UPDATE `movie` SET `title` = '"+movie.title+"', `releaseDate` = '"+movie.releaseDate+"', `description` = '"+movie.description+"', `duration` = '"+movie.duration+"', `genre` = '"+movie.genre+"', `director` = '"+movie.director+"', `rating` = '"+movie.rating+"' WHERE `movie`.`id` = "+movie.id+"";
            MySqlConnection databaseConnection = new MySqlConnection(MysqlConnetionString);
            MySqlCommand comandDatabase = new MySqlCommand(query, databaseConnection);
            comandDatabase.CommandTimeout = 60;
            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = comandDatabase.ExecuteReader();

            }
            catch (Exception e)
            {
                throw e;
            }
        }



        //cinema hall
        //cinema hall
        //cinema hall
        //cinema hall
        public List<Models.CinemaHall> getCinemaHall()
        {
            List<Models.CinemaHall> cinemaHalls = new List<Models.CinemaHall>();

            String query = "SELECT * FROM cinema_hall";

            MySqlConnection databaseConnection = new MySqlConnection(MysqlConnetionString);
            MySqlCommand comandDatabase = new MySqlCommand(query, databaseConnection);

            comandDatabase.CommandTimeout = 60;
            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = comandDatabase.ExecuteReader();
                if (myReader.HasRows)
                {
                    while (myReader.Read())
                    {
                        Models.CinemaHall cinemaHall = new Models.CinemaHall(int.Parse(myReader[0].ToString()), myReader[1].ToString(), int.Parse(myReader[2].ToString()), myReader[3].ToString());

                        // cinemaHall.showCinemaHall();
                        cinemaHalls.Add(cinemaHall);
                    }

                    return cinemaHalls;
                }
                else
                {
                    return cinemaHalls;

                }

            }
            catch (Exception e)
            {
                throw e;

            }

        }


        public  void addCinemaHall(Models.CinemaHall cinemaHall)
        {

            String query = "INSERT INTO `cinema_hall` (`id`, `name`, `capacity`, `location`) VALUES (NULL, '"+cinemaHall.name+"', '"+cinemaHall.capacity+"', '"+cinemaHall.capacity+"')";

            MySqlConnection databaseConnection = new MySqlConnection(MysqlConnetionString);
            MySqlCommand comandDatabase = new MySqlCommand(query, databaseConnection);
            comandDatabase.CommandTimeout = 60;
            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = comandDatabase.ExecuteReader();

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Models.CinemaHall findCinemaHall(int id)
        {
            String query = "SELECT * FROM `cinema_hall` WHERE id = " + id;

            MySqlConnection databaseConnection = new MySqlConnection(MysqlConnetionString);
            MySqlCommand comandDatabase = new MySqlCommand(query, databaseConnection);

            comandDatabase.CommandTimeout = 60;
            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = comandDatabase.ExecuteReader();
                if (myReader.HasRows)
                {
                    if (myReader.Read())
                    {
                        Console.WriteLine("found");

                        Models.CinemaHall cinemaHall = new Models.CinemaHall(int.Parse(myReader[0].ToString()), myReader[1].ToString(),int.Parse(myReader[2].ToString()), myReader[3].ToString());

                        cinemaHall.showCinemaHall();
                        return cinemaHall;
                    }

                    throw new Exception("Reader can't read");


                }
                else
                {
                    throw new Exception("CinemaHall not found ");
                }

            }
            catch (Exception e)
            {
                throw e;
            }
        }


        public void removeCinemahall(int id)
        {
            String query = "DELETE FROM `cinema_hall` WHERE `cinema_hall`.`id` = " + id + ";";
            MySqlConnection databaseConnection = new MySqlConnection(MysqlConnetionString);
            MySqlCommand comandDatabase = new MySqlCommand(query, databaseConnection);
            comandDatabase.CommandTimeout = 60;
            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = comandDatabase.ExecuteReader();

            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public void updateCinemaHall(Models.CinemaHall cinemaHall)
        {
            String query = "UPDATE `cinema_hall` SET `name` = '"+cinemaHall.name+"', `capacity` = '"+cinemaHall.capacity+" ', `location` = '"+cinemaHall.location+"' WHERE `cinema_hall`.`id` = "+cinemaHall.id+"";
            MySqlConnection databaseConnection = new MySqlConnection(MysqlConnetionString);
            MySqlCommand comandDatabase = new MySqlCommand(query, databaseConnection);
            comandDatabase.CommandTimeout = 60;
            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = comandDatabase.ExecuteReader();

            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }



    



    
}
