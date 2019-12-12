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

    }

    
}
