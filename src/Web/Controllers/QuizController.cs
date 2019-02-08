using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class QuizController : Controller
    {
        public IActionResult ShowText()
        {
            return Content("Here is the Quiz. ");
        }
        public IActionResult ShowJSON()
        {
            return Json(new { name = "new Question", quiz = "This is my first Quiz." });
        }
        public IActionResult ShowHTML()
        {
            var h = "<!DOCTYPE html><html><body>Question 1. .NET Core is designed to integrate seamlessly with a variety of client-side frameworks, such as AngularJS, React, and Vue. </body></html>";
            return Content(h, "text/html");
        }

        public IActionResult ShowView()
        {
            return View();
        }
    }
}

