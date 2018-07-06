﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WordCounter;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WordCounter.Controllers
{
    public class ListingsController : Controller
    {
        [HttpPost("/word_counter_results")]
        public ActionResult Results(string word, string list)
        {
            RepeatCounter newRepeatCounter = new RepeatCounter(word, list);
            newRepeatCounter.SetSingleWord(Request.Form["job-title"]);
            newRepeatCounter.SetListOfWords(Request.Form["job-description"]);
            return View("Results", newRepeatCounter);
        }
    }
}
