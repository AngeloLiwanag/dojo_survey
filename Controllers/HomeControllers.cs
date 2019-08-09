using Microsoft.AspNetCore.Mvc;
using System;
namespace Home
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost("result")]
        public IActionResult Method(string name, string location, string language, string comment)
        {
            ViewBag.name = name;
            ViewBag.location = location;
            ViewBag.language = language;
            ViewBag.comment = comment;

            return View("result");
        }
        [HttpGet("result")]
        public IActionResult result()
        {
            return View();
        }
    }
}