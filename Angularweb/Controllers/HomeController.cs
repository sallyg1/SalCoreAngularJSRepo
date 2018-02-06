using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Interface;

namespace Angularweb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICustomerService _custService;
        public HomeController(ICustomerService _custService)
        {
            this._custService = _custService;
        }
        public IActionResult Index()
        {
            var result = _custService.GetCustomer();
            return View();
        }

        public IActionResult Error()
        {
            ViewData["RequestId"] = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
            return View();
        }
    }
}
