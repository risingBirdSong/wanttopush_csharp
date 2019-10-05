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
        public ViewResult Contacts()
        {
            return View();
        }
        [HttpGet("razorfun")]
        public IActionResult Razorfun()
        {
            return View();
        }
        [HttpGet("datetime")]
        public IActionResult Datetime()
        {
            return View();
        }

        [HttpGet("form_norm")]
        public IActionResult form_norm()
        {
            var locations = new List<string> { "Vancouver", "Portland", "Spokane" };
            var languages = new List<string> { "french", "english", "german" };
            var myForm = new form_norm();
            myForm.Location = locations;
            myForm.FavoriteLanguage = languages;
            return View(myForm);
      
    }
        [HttpPost("form_norm")]
        [ValidateAntiForgeryToken]

        public IActionResult norm_result(form_norm postedForm)
        {

            return View(postedForm);
        }


    [HttpGet("form")]
    public IActionResult Form()
    {
        var myForm = new formModel();
        return View(myForm);
    }

    [HttpPost("result")]
    [ValidateAntiForgeryToken]
    public IActionResult Result(string Name, string myLocations, string Languages, string Comment)
    {
        myLocations outLocation;
        Languages outLanguage;
        Enum.TryParse<myLocations>(myLocations, out outLocation);
        Enum.TryParse<Languages>(Languages, out outLanguage);
        var myresult = new formModel();
        myresult.Name = Name;
        myresult.myLocations = outLocation;
        myresult.Languages = outLanguage;
        myresult.Comment = Comment;
        return View(myresult);
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
}
