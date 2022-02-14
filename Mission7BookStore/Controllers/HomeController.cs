using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
//using Mission7BookStore.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission7BookStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        //private BookStoreContext context { get; set; }

        //public HomeController(BookStoreContext temp) => context = temp;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //var blah = context.Books.ToList();
            return View();
        }


    }
}
