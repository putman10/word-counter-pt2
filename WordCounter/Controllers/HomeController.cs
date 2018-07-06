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
            newCounter.SetSingleWord(Request.Query["singleWord"]);
            newCounter.SetListOfWords(Request.Query["listOfWords"]);
            return View(newCounter);
        }
    }
}
