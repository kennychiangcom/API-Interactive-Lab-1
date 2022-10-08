using API_Interactive_Lab_1.Controllers;
using NUnit.Framework;

namespace API_Interactive_Lab_1.Tests//.Controllers
{
    public class HomeControllerTests
    {
        [Test]
        public void TestGetHome()
        {
            // ARRANGE
            string expectedContent = "Welcome to the Drinks API!";
            var controller = new HomeController();
            // ACT
            var result = controller.Get();
            // ASSERT
            Assert.AreEqual(expectedContent, result);
        }
    }
}
