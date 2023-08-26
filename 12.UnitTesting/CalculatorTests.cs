using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _12.UnitTesting
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void TestAddition()
        {
            int result = Calculator.Add(5, 3);
            Assert.AreEqual(8, result);
        }
    }

    public class Calculator
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
    }
}
