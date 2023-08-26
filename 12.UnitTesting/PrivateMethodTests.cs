using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;

namespace _12.UnitTesting
{
    [TestClass]
    public class PrivateMethodTests
    {
        [TestMethod]
        public void TestPrivateMethod()
        {
            var instance = new ExampleClass();
            var privateMethod =
                typeof(ExampleClass).GetMethod(
                    "MultiplyByTwo",
                    BindingFlags.NonPublic | BindingFlags.Instance);
            int result = (int)privateMethod.Invoke(instance, new object[] { 5 });

            Assert.AreEqual(10, result);
        }
    }

    public class ExampleClass
    {
        private int MultiplyByTwo(int value)
        {
            return value * 2;
        }
    }
}
