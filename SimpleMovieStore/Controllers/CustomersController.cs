using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SimpleMovieStore.Models;
using SimpleMovieStore.ViewModels;

namespace SimpleMovieStore.Controllers
{
    public class CustomersController : Controller
    {
        List<Customer> psuedoCustomers = new List<Customer>
        {
            new Customer {Name = "Bob"},
            new Customer {Name = "Sharon"},
            new Customer {Name = "Veroz"},
            new Customer {Name = "Azteri"},
            new Customer {Name = "Moquiero"},
            new Customer {Name = "Mobister"}

        };

        // GET: Customers
        [Route("Customers")]
        public ViewResult Index()
        {
            var viewModel = new ViewCustomersViewModel
            {
                Customers = psuedoCustomers
            };

            return View(viewModel);
        }

        // GET: Customers/Details/Id
        [Route("Customers/Details/{Id}")]
        public ViewResult CustomerDetails(int Id)
        {
            return View(psuedoCustomers[Id]);
        }
    }
}