using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using System.Web.Mvc;
using NUnit.Framework;

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

            //Assert.AreEqual("Your application description page.", result.Result  ViewBag.StatusMessage)
            NUnit.Framework.Assert.NotNull(resultRes);
            //Assert.Fail();
        }
    }
}