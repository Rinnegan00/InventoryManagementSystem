using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using InventoryManagementSystem;
using InventoryManagementSystem.Controllers;

namespace UnitTestProject
{
    [TestClass]
    public class PurchaseControllerTest
    {
        [TestMethod]
        public void Index()
        {
            //Arrange
            ProductController controller = new ProductController();

            //Act
            ViewResult result = controller.Index() as ViewResult;

            //Assert
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void DisplayPurchase()
        {
            //Arrange
            ProductController controller = new ProductController();

            //Act
            ViewResult result = controller.DisplayProduct() as ViewResult;

            //Assert
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void PurchaseProduct()
        {
            //Arrange
            ProductController controller = new ProductController();

            //Act
            ViewResult result = controller.CreateProduct() as ViewResult;

            //Assert
            Assert.IsNotNull(result);
        }
    }
}
