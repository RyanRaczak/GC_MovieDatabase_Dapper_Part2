using Dapper;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GC_MovieDatabase_Dapper.Models
{
    public class MovieDAL
    {
        //DAL = Data Access Layer
        //This containts all of the code for talking to the DB and can be reused anywhere
        //Need to make all CRUD functions

        //Read All
        //Returns all rows from movies table
        public List<Movie> GetMovies()
        {
            using (var connect = new MySqlConnection(Secret.Connection))
                {
                    string sql = $"select * from movies";

                    connect.Open();

                    List<Movie> movies = connect.Query<Movie>(sql).ToList();

                    connect.Close();
                    
                    return movies;
                }
        }

        //Read Selected
        //Returns all rows by specified sql statement
        public List<Movie> GetMovies(string sql)
        {
            using (var connect = new MySqlConnection(Secret.Connection))
            {
                connect.Open();

                List<Movie> movies = connect.Query<Movie>(sql).ToList();

                connect.Close();

                return movies;
            }
        }

        //Read Single
        //Returns one row from movie table that match ID
        public Movie GetMovie(int id)
        {
            if (ValidID(id))
            {
                using (var connect = new MySqlConnection(Secret.Connection))
                {
                    string sql = $"select * from movies where ID = {id}";
                    connect.Open();
                    //Query always returns a list regardless of how many movies we want
                    //Even if our query is meant to return 1 movie, we will still need
                    //to pull it ouf of a list of count 1
                    Movie m = connect.Query<Movie>(sql).First();
                    connect.Close();
                    return m;
                }
            }
            Movie failed = new Movie();
            return failed;
            
        }

        //Delete Single
        //Takes in an ID and deletes that row in the DB
        public void DeleteMovie(int id)
        {
            using (var connect = new MySqlConnection(Secret.Connection))
            {
                string sql = $"delete from movies where ID = {id}";
                connect.Open();
                connect.Query<Movie>(sql);
                connect.Close();
            }
        }

        //Update Single
        //Takes a movie model and replaces the one in DB with the passed object
        public void UpdateMovie(Movie m)
        {
            using (var connect = new MySqlConnection(Secret.Connection))
            {
                string sql = $"update movies " +
                    $"set Title = '{m.Title}', Genre = '{m.Genre}', `Year` = {m.Year}, Runtime = {m.Runtime} " +
                    $"where ID = {m.ID}";
                connect.Open();
                connect.Query<Movie>(sql);
                connect.Close();
            }
        }

        //Create Single
        //Takes a movie model and adds it to the DB
        public void CreateMovie(Movie m)
        {
            using (var connect = new MySqlConnection(Secret.Connection))
            {
                string sql = $"insert into movies values({0},'{m.Title}','{m.Genre}',{m.Year},{m.Runtime})";

                connect.Open();

                connect.Query(sql);

                connect.Close();
            }
        }

        public bool ValidID(int id)
        {
            List<Movie> movies = GetMovies();
            foreach (var UID in movies)
            {
                if (UID.ID == id)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
