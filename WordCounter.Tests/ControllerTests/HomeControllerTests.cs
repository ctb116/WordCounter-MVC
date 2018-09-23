using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
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
      // Arrange - created an instance of our HomeController
      HomeController controller = new HomeController();

      // Act - a variable of indexView stores the return from ActionResult Index()
      ActionResult indexView = controller.Index();

      // Assert - our variable indexView is a type of View result
      Assert.IsInstanceOfType(indexView, typeof(ViewResult));
    }
  }
}
