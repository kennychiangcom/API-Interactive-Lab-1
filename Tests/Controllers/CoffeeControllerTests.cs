using API_Interactive_Lab_1.Controllers;
using API_Interactive_Lab_1.Models;
using NUnit.Framework;

namespace API_Interactive_Lab_1.Tests//.Controllers
{
    public class CoffeeControllerTests
    {
        [Test]
        public void TestGetCoffee()
        {
            // ARRANGE
            string expectedcontent = "I like coffee!";
            var controller = new CoffeeController();
            // ACT
            var result = controller.Get();
            // ASSERT
            Assert.AreEqual(expectedcontent, result);
        }
        [Test]
        public void TestGetCoffee_NoValueProvided()
        {
            // ARRANGE
            Coffee expected = new Coffee() { Name = "latte", Id = -1 };
            var controller = new CoffeeController();
            // ACT
            var result = controller.Get(null);
            // ASSERT
            Assert.AreEqual(expected.Name, result.Name);
            Assert.AreEqual(expected.Id, result.Id);
        }
        [Test]
        public void TestGetCoffee_ValueProvided()
        {
            // ARRANGE
            Coffee expected = new Coffee() { Name = "cappucino", Id = 962 };
            var controller = new CoffeeController();
            // ACT
            var result = controller.Get("cappucino");
            // ASSERT
            Assert.AreEqual(expected.Name, result.Name);
            Assert.AreEqual(expected.Id, result.Id);
        }
        [Test]
        public void TestGetCoffee_LatteProvided()
        {
            // ARRANGE
            Coffee expected = new Coffee() { Name = "latte", Id = -1 };
            var controller = new CoffeeController();
            // ACT
            var result = controller.Get("latte");
            // ASSERT
            Assert.AreEqual(expected.Name, result.Name);
            Assert.AreEqual(expected.Id, result.Id);
        }
    }
}
