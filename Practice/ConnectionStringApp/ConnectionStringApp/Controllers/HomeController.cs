using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ConnectionStringApp.DatabaseContext;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ConnectionStringApp.Models;

namespace ConnectionStringApp.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _db;
        
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            ICollection<Customer> customerList = _db.Customers.ToList();
            return View(customerList);
        }
        [HttpGet]
        public IActionResult Privacy()
        {
             
            return View();
        }

        [HttpPost]

        public IActionResult Privacy(Customer model)
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
