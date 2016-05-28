using Microsoft.VisualStudio.TestTools.UnitTesting;
using HKOWebMVC4.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace HKOWebMVC4.Controllers.Tests
{
    [TestClass()]
    public class ManageControllerTests
    {

        [TestMethod()]
        public void IndexTest()
        {
            // Arrange
            ManageController controller = new ManageController();

            // Act
            Task<ActionResult> result = controller.Index(ManageController.ManageMessageId.AddPhoneSuccess, null) as Task<ActionResult>;

            // Assert
            var resultRes = result.Result;

            //Assert.AreEqual("Your application description page.", result.Result  ViewBag.StatusMessage);

            Assert.Fail();
        }
    }
}