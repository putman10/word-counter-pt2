using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WordCounter;

namespace WordCounter.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult WordCounterForm()
        {
            return View();
        }
    }
}
