using GC_MovieDatabase_Dapper.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GC_MovieDatabase_Dapper.Controllers
{
    public class MovierentalsController : Controller
    {
        MovieDAL MovieDB = new MovieDAL();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registration(Movie m)
        {
            if (ModelState.IsValid)
            {
                MovieDB.CreateMovie(m);
                return RedirectToAction("Result", m);
            }
            else
            {
                return View();
            }
        }

        public IActionResult Result(Movie m)
        {
            if (ModelState.IsValid)
            {
                return View(m);
            }
            else
            {
                return RedirectToAction("Registration");
            }

        }

        public IActionResult ListMovies()
        {
            MovieDAL connect = new MovieDAL();
            List<Movie> movies = connect.GetMovies();
            return View(movies);
        }

        public IActionResult Details(int id)
        {
            Movie m = MovieDB.GetMovie(id);
            if (m.Title != null)
            {
                return View(m);
            }
            else
            {
                return RedirectToAction("Error");
            }
        }

        //This will show full details of what is inteded to delete
        //And prompt the user if they're sure they want to do it
        public IActionResult Delete(int id)
        {
            if (MovieDB.ValidID(id))
            {
                Movie m = MovieDB.GetMovie(id);
                return View(m);
            }
            else
            {
                return RedirectToAction("Error");
            }
        }

        [HttpPost]
        public IActionResult DeleteFromDb(int id)
        {
            MovieDB.DeleteMovie(id);
            return RedirectToAction("ListMovies");
        }

        //This action displays the view as well as pass the movie
        //to the form
        public IActionResult Edit(int id)
        {
            if (MovieDB.ValidID(id))
            {
                Movie m = MovieDB.GetMovie(id);
                return View(m);
            }
            else
            {
                return RedirectToAction("Error");
            }
        }

        [HttpPost]
        public IActionResult Edit(Movie m)
        {
            if (ModelState.IsValid)
            {
                MovieDB.UpdateMovie(m);
                return RedirectToAction("ListMovies");
            }
            else
            {
                return RedirectToAction("Error");
            }
        }

        public IActionResult Search()
        {
            return View();
        }

        public IActionResult SearchResult(Movie m)
        {
            string sql;
            if(m.ID != 0)
            {
                //Search ID
                sql = $"select * from movies where id = {m.ID}";
            }
            else if (m.Title != null)
            {
                //Search Title
                sql = $"select * from movies where Title like '{m.Title}%'";
            }
            else
            {
                //Search Genre
                sql = $"select * from movies where Genre = '{m.Genre}'";
            }
            List<Movie> movies = MovieDB.GetMovies(sql);
            return View(movies);
        }
        public IActionResult Error()
        {
            return View();
        }
    }
}
