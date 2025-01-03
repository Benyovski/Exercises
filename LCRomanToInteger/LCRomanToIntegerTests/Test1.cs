using LCRomanToInteger;

namespace LCRomanToIntegerTests
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(3, new Program().RomanToInt("III"));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(4, new Program().RomanToInt("IV"));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(9, new Program().RomanToInt("IX"));
        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual(58, new Program().RomanToInt("LVIII"));
        }

        [TestMethod]
        public void TestMethod5()
        {
            Assert.AreEqual(1994, new Program().RomanToInt("MCMXCIV"));
        }

        [TestMethod]
        public void TestMethod6()
        {
            Assert.AreEqual(621, new Program().RomanToInt("DCXXI"));
        }
    }
}
