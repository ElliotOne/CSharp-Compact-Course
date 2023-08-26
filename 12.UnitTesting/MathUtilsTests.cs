using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _12.UnitTesting
{
    [TestClass]
    public class MathUtilsTests
    {
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestDivideByZero()
        {
            MathUtils.Divide(10, 0);
        }
    }

    public class MathUtils
    {
        public static int Divide(int dividend, int divisor)
        {
            if (divisor == 0)
            {
                throw new DivideByZeroException();
            }

            return dividend / divisor;
        }
    }
}
