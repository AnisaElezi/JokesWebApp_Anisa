using System;
using Microsoft.AspNetCore.Mvc;

namespace MyWebApp.Controllers
{
    public class HomeController : Controller
    {
        // Incorrect method naming convention
        public IActionResult Index_Page()
        {
            // Unused variable
            string UnusedVariable = "Hello World";

            // Missing semicolon (syntax error)
            ViewData["Message"] = "Welcome to my web app"

            // Incorrect return type (should be View or JsonResult)
            return "This should be a view";
        }

        // Method with no return statement (missing return View())
        public IActionResult About()
        {
            ViewData["Title"] = "About Page";
        }

        // Wrong visibility modifier (should be public or private)
        void Contact()
        {
            ViewData["Title"] = "Contact Page";
            Console.WriteLine("Contact Page Loaded");
        }
    }
}
