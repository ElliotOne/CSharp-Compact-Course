using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _12.UnitTesting
{
    [TestClass]
    public class StringUtilsTests
    {
        [TestMethod]
        [DataRow("hello", 2)]
        [DataRow("world", 1)]
        [DataRow("test", 1)]
        [DataRow("example", 3)]
        public void TestCountVowels(string input, int expectedCount)
        {
            int result = StringUtils.CountVowels(input);
            Assert.AreEqual(expectedCount, result);
        }
    }

    public class StringUtils
    {
        public static int CountVowels(string input)
        {
            List<char> vowels = new List<char>()
            {
                'a', 'e', 'i', 'o', 'u'
            };

            return input.Count(c => vowels.Contains(char.ToLower(c)));
        }
    }
}
