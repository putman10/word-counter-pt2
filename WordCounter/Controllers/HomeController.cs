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
        [Route("/")]
        public ActionResult WordCounterForm()
        {
            return View();
        }

        [Route("/word_counter_results")]
        public ActionResult WordCounterResults()
        {
            RepeatCounter newCounter = new RepeatCounter();
            newCounter.SetOccupation(Request.Query["singleWord"]);
            newCounter.SetNounOne(Request.Query["listOfWords"]);
            return View(newCounter);
        }
    }
}
