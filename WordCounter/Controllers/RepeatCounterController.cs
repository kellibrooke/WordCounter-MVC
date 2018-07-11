using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace WordCounter.Controllers
{
    public class RepeatCounterController : Controller
    {
        [HttpGet("/game")]
        public ActionResult Game()
        {
            return View();
        }

        [HttpPost("/results")]
        public ActionResult Results()
        {
            RepeatCounter newCounter = new RepeatCounter();
            newCounter.SetUserCheckWord(Request.Form["word"]);
            newCounter.SetUserSentence(Request.Form["sentence"]);
            newCounter.CreateWordTally();
            return View(newCounter);
        }

    }
}
