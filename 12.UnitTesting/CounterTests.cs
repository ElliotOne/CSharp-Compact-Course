using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _12.UnitTesting
{
    [TestClass]
    public class CounterTests
    {
        private Counter counter;

        [TestInitialize]
        public void Initialize()
        {
            counter = new Counter();
        }

        [TestMethod]
        public void TestIncrement()
        {
            counter.Increment();
            Assert.AreEqual(1, counter.Value);
        }

        [TestMethod]
        public void TestDecrement()
        {
            counter.Decrement();
            Assert.AreEqual(-1, counter.Value);
        }

        [TestCleanup]
        public void CleanUp()
        {
            counter = null;
        }
    }

    public class Counter
    {
        public int Value { get; private set; }

        public void Increment()
        {
            Value++;
        }

        public void Decrement()
        {
            Value--;
        }
    }
}
