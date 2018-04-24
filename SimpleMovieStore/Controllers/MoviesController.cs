using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SimpleMovieStore.Models;
using SimpleMovieStore.ViewModels;

namespace SimpleMovieStore.Controllers
{
    public class MoviesController : Controller
    {
        List<Movie> MovieList = new List<Movie>
        {
            new Movie{ Name = "Wall-e"},
            new Movie{ Name = "Black Panther"},
            new Movie{ Name = "Shadow of Mordor"},
            new Movie{ Name = "Fantastic 6"}
        };

        // GET: Movies
        [Route("Movies")]
        public ViewResult Index()
        {
            var viewModel = new ViewMoviesViewModel
            {
                Movies = MovieList
            };
            return View(viewModel);
        }
//        // GET: Movies/Random
//        public ViewResult Random()
//        {
//            var movie = new Movie() {Name = "Shrek!"};
//            var customers = new List<Customer>
//            {
//                new Customer {Name = "Bob"},
//                new Customer {Name = "Sharon"},
//                new Customer {Name = "Veroz"},
//                new Customer {Name = "Azteri"},
//                new Customer {Name = "Moquiero"},
//                new Customer {Name = "Mobister"}
//            };
//
//            var viewModel = new RandomMovieViewModel
//            {
//                Movie = movie,
//                Customers = customers
//            };
//
//            return View(viewModel);
//        }

//        // GET: Movies/Edit/id
//        public ContentResult Edit(int id)
//        {
//            return Content("id: "+id);
//        }
//
//        // GET: Movies/PageIndex/Sortby
//        [Route("Movies/{pageIndex}/{sortBy}")]
//        public ContentResult Index(int? pageIndex, string sortBy)
//        {
//            if (!pageIndex.HasValue)
//                pageIndex = 1;
//            if (String.IsNullOrWhiteSpace(sortBy))
//                sortBy = "Name";
//
//            return Content(String.Format("pageIndex = {0} && SortBy = {1}", pageIndex, sortBy));
//        }
//
//        //GET: Movies/Released/Year/Month
//        [Route("Movies/Released/{Year:regex(\\d{4}):range(1940, 2020)}/{Month:regex(\\d{2}):range(1, 12)}")]
//        public ContentResult ByReleaseDate(int year, byte month)
//        {
//            return Content(String.Format("Year {0} | Month {1}", year, month));
//        }
    }
}