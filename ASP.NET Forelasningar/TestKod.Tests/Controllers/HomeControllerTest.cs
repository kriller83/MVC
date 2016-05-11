using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestKod;
using TestKod.Controllers;

namespace TestKod.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest   //Gör en instans av den riktiga controllern (den riktiga klassen)
    {
        [TestMethod] 
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;  //anropar själva metoden. Ett resultat från vyn. Anropar controller.index (homecontrollern).

            // Assert
            Assert.IsNotNull(result);  
        }

        [TestMethod]
        public void About()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

        [TestMethod]
        public void Contact()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
