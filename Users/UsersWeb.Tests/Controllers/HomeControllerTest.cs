using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using UsersWeb.Controllers;

namespace UsersWeb.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        HomeController _controller = new HomeController(new UsersDomain());

        [TestMethod]
        public void Index()
        {
            // Act
            ViewResult result = _controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void About()
        {
            // Act
            ViewResult result = _controller.About() as ViewResult;

            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

        [TestMethod]
        public void Contact()
        {
            // Act
            ViewResult result = _controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
