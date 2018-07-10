using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WordCounter;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WordCounter.Controllers
{
    public class WordCounterController : Controller
    {
        [HttpPost("/word_counter_results")]
        public ActionResult Results(string singleWord, string listOfWords)
        {
            RepeatCounter newRepeatCounter = new RepeatCounter(singleWord, listOfWords);
            newRepeatCounter.Final();
            return View("Results", newRepeatCounter);
        }
    }
}
