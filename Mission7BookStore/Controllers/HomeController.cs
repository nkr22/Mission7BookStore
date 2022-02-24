using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission7BookStore.Models;
using Mission7BookStore.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission7BookStore.Controllers
{
    public class HomeController : Controller
    {

        private IBookstoreRepository repo;

        public HomeController (IBookstoreRepository temp)
        {
            repo = temp;
        }
         
        //this is now making the repo a temp variable that we can pass to our index page
        public IActionResult Index(string bookCategory, int pageNum=1)
        {
            int pageSize = 10;

            var x = new BooksViewModel
            {
                Books = repo.Books
                .Where(b=>b.Category==bookCategory || bookCategory==null)
                .OrderBy(b => b.Title)
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize),

                PageInfo = new PageInfo
                {
                    TotalNumBooks = (bookCategory==null ? 
                        repo.Books.Count() : 
                        repo.Books.Where(x=> x.Category==bookCategory).Count()),
                    BooksPerPage = pageSize,
                    CurrentPage = pageNum

                }
            };
            return View(x);
        }


    }
}
