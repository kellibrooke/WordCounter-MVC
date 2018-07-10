using Microsoft.AspNetCore.Mvc;

namespace WordCounter.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

    }
}
