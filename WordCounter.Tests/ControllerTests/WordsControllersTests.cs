using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Controllers;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class WordsControllerTest
  {
    [TestMethod]
    public void Index_HasCorrectModelView_True()
    {
      // WordsController is singular here but plural in the Controllers file. Test failed if both matched?
      WordsController controller = new WordsController();

      ActionResult indexView = controller.Index();

      Assert.IsInstanceOfType(indexView, typeof(ViewResult));
    }
    [TestMethod]
    public void CreateForm_HasCorrectModelView_True()
    {

      WordsController controller = new WordsController();

      ActionResult createFormView = controller.CreateForm();

      Assert.IsInstanceOfType(createFormView, typeof(ViewResult));
    }

    // Problem with Act - "cannot convert type object to ViewResult - epicodus Controller Testing C#"

    // [TestMethod]
    // public void Index_HasCorrectModelType_WordList()
    // {
    //   WordsController controller = new WordsController();
    //   ViewResult indexView = controller.Index() as ViewResult;
    //
    //   // Act - extract the model from indexView using ViewData.Model - This contains the list
    //   ViewResult result = indexView.ViewData.Model;
    //
    //   // Assert - If there is a list from Act above which is now result, compare to List
    //   Assert.IsInstanceOfType(result, typeof(List<Word>));
    // }
  }
}
