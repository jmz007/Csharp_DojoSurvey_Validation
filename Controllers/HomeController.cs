using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Csharp_DojoSurvey.Models;

namespace Csharp_DojoSurvey.Controllers
{

    public class HomeController : Controller
    {
        // GET: /<controller>/
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost("result")]
        public IActionResult Result(string Name, string Locations, string Languages, string Comments){
            Models.Survey info = new Models.Survey(Name,Locations,Languages,Comments);
            TryValidateModel(info);

            if (ModelState.IsValid)
            {
                return View("result",info);
            }
            else
            {
                return View("index");
            }
        }
    }
}







//         [HttpPost("result")]
//         public IActionResult Result(Survey MySurvey)
//         {
//             // ViewBag.Name = Name;
//             // ViewBag.Locations = Locations;
//             // ViewBag.Languages= Languages;
//             // ViewBag.Comments = Comments;
//             return View(MySurvey);
//         }
//     }
// }

