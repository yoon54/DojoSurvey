using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Dojo_Survey.Controllers
{
    public class HomeController : Controller   
    {
        public static List<string> SurveyInfo = new List<string>()
        {
        };

        [HttpGet("")]
        public IActionResult Home()
        {
            return View();
        }
        [HttpPost("result")]
        public IActionResult Submit(string name, string location, string lang, string msg)
        {
            ViewBag.SurveyInfo = SurveyInfo;
            SurveyInfo.Add(name);
            SurveyInfo.Add(location);
            SurveyInfo.Add(lang);
            SurveyInfo.Add(msg);
            return View("Result");
        }
    }
}