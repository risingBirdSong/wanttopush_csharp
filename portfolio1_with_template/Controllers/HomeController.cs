using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using portfolio1_with_template.Models;

namespace portfolio1_with_template.Controllers
{
    public class HomeController : Controller
    {
         [HttpGet("")]

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("projects")]
        public IActionResult Projects()
        {
            return View();
        }

        [HttpGet("contacts")]
        public IActionResult Contacts()
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
