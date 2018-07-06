using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Controllers;
using WordCounter;

namespace WordCounter.Tests
{
    [TestClass]
    public class ResultsControllerTest
    {
        [TestMethod]
        public void Index_ReturnsCorrectView_True()
        {
            //Arrange
            ResultsController controller = new ResultsController();

            //Act
            ActionResult indexView = controller.Results("dog", "dog dog");

            //Assert
            Assert.IsInstanceOfType(indexView, typeof(ViewResult));
        }

        [TestMethod]
        public void Index_HasCorrectModelType_ItemList()
        {
            //Arrange
            ViewResult indexView = new ResultsController().Results("dog", "dog dog") as ViewResult;

            //Act
            var result = indexView.ViewData.Model;

            //Assert
            Assert.IsInstanceOfType(result, typeof(string));
        }
    }
}