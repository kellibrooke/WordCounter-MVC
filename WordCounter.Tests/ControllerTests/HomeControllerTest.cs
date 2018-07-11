using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using WordCounter.Controllers;
using WordCounter.Models;

namespace WordCounter.Tests
{
    [TestClass]
    public class HomeControllerTest
    {
      [TestMethod]
        public void Index_ReturnsCorrectView_True()
        {
            HomeController controller = new HomeController();
            ActionResult actual = controller.Index();
            Assert.IsInstanceOfType(actual, typeof(ViewResult));
        }

    }
}
