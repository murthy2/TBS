using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TBS.WebUI.Controllers;
using System.Web.Mvc;

namespace TBS.WebUI.Tests.Controllers
{
    [TestClass]
    public class TitlesControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            TitlesController controller = new TitlesController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.AreEqual("Success", result.ViewBag.Message);
        }

    }
}
