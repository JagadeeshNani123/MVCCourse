using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC_Course.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Course.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult RegisterForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegisterForm(WebinarInvites response)
        {
            if (ModelState.IsValid)
            {
                Repository.AddResponse(response);
                return View("ThankYou", response);
            }
            else
                return View();
        }

        [HttpGet]
        public IActionResult ListOfResponses()
        {
            return View(Repository.Responses.Where(r=> r.WillJoin==true));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
