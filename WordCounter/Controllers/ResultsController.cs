using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WordCounter;

namespace WordCounter.Controllers
{
    public class ResultsController : Controller
    {
        [HttpPost("/word_counter_results")]
        public ActionResult Results()
        {
            RepeatCounter newCounter = new RepeatCounter();
            newCounter.SetSingleWord(Request.Form["singleWord"]);
            newCounter.SetListOfWords(Request.Form["listOfWords"]);
            newCounter.UpdateList();
            return View(newCounter.GetList());
        }
    }
}
