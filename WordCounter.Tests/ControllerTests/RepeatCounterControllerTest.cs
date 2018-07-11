using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Controllers;
using WordCounter.Models;

namespace WordCounter.Tests
{
    [TestClass]
    public class RepeatCounterControllerTest
    {
      [TestMethod]
      public void Game_ReturnsCorrectView_True()
      {
          RepeatCounterController controller = new RepeatCounterController();
          ActionResult actual = controller.Game();
          Assert.IsInstanceOfType(actual, typeof(ViewResult));
      }

      // [TestMethod]
      // public void Results_HasCorrectModelType_RepeatCounter()
      //  {
      //      RepeatCounterController controller = new RepeatCounterController();
      //      IActionResult actionResult = controller.Results();
      //      ViewResult indexView = controller.Results() as ViewResult;
      //      var result = indexView.ViewData.Model;
      //      Assert.IsInstanceOfType(result, typeof(RepeatCounter));
      //  }

    }
}
