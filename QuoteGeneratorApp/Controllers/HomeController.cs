using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QuoteGeneratorApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace QuoteGeneratorApp.Controllers
{
    public class HomeController : Controller
    {
        private static MockDB MockDB = new MockDB();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Quotes(string author, string quoteBody, DateTime quoteTime)
        {

            var quotes = MockDB.Quotes().OrderBy(q => q.Author);


            foreach (var quo in quotes)
            {
                author = quo.Author;
                quoteBody = quo.QuoteBody;
                quoteTime = quo.When;
            }
            
            return View("Quotes", new Quote { Author = author, QuoteBody = quoteBody, When = quoteTime });

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
