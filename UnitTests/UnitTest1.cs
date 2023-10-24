
using Calculations;
using System.Globalization;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalculationsConstructorTest()
        {
            Calculator calculator = new Calculator();
            Assert.IsNotNull(calculator);
        }
        [TestMethod]
        public void AddTest()
        {
            Calculator calculator = new Calculator();
            int result = calculator.Add(3, 4);
            int expectedValue = 7;
            Assert.AreEqual(expectedValue, result);
        }
        [TestMethod]
        public void SubtractTest()
        {
            Calculator calculator = new Calculator();
            double result = calculator.subtract(32, 4);
            int expectedValue = 28;
            Assert.AreEqual(expectedValue, result);
        }
        [TestMethod]
        public void MultiplyTest()
        {
            Calculator calculator = new Calculator();
            int result = calculator.multiply(32, 4);
            int expectedValue = 32*4;
            Assert.AreEqual(expectedValue, result);

        }
        [TestMethod]
        public void DivideTest()
        {
            Calculator calculator = new Calculator();
            float result = calculator.divide(32, 4);
            int expectedValue = 32/4;
            Assert.AreEqual(expectedValue, result);

        }
        [TestMethod]
        public void DivideByZeroTest() 
        { 
            Calculator calculator = new Calculator();
            float result = calculator.divide(42, 0);
            int expectedValue = 42;
            Assert.AreEqual(expectedValue, result);
        }
        [TestMethod]
        public void medianTest()
        {
            Calculator calculator = new Calculator();
            List<int> list = new List<int>();
            list.Add(7);
            list.Add(5);
            list.Add(6);
            int result = calculator.median(list);
            int expectedValue = 6;
            Assert.AreEqual(expectedValue, result);

        }
    }
}