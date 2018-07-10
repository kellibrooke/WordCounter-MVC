using Microsoft.AspNetCore.Mvc;

namespace WordCounter.Controllers
{
    public class RepeatCounterController : Controller
    {
        [HttpGet("/game")]
        public ActionResult Game()
        {
            return View();
        }

        [HttpGet("/results")]
        public ActionResult Results()
        {
            return View();
        }

    }
}
