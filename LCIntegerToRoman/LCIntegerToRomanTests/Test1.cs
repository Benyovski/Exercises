namespace LCIntegerToRomanTests
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("III", new LCIntegerToRoman.Program().IntToRoman(3));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual("IV", new LCIntegerToRoman.Program().IntToRoman(4));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual("IX", new LCIntegerToRoman.Program().IntToRoman(9));
        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual("LVIII", new LCIntegerToRoman.Program().IntToRoman(58));
        }

        [TestMethod]
        public void TestMethod5()
        {
            Assert.AreEqual("MCMXCIV", new LCIntegerToRoman.Program().IntToRoman(1994));
        }

        [TestMethod]
        public void TestMethod6()
        {
            Assert.AreEqual("MMMCMXCIX", new LCIntegerToRoman.Program().IntToRoman(3999));
        }

        [TestMethod]
        public void TestMethod7()
        {
            Assert.AreEqual(string.Empty, new LCIntegerToRoman.Program().IntToRoman(0));
        }

        [TestMethod]
        public void TestMethod8()
        {
            Assert.AreEqual(string.Empty, new LCIntegerToRoman.Program().IntToRoman(4000));
        }

        [TestMethod]
        public void TestMethod9()
        {
            Assert.AreEqual(string.Empty, new LCIntegerToRoman.Program().IntToRoman(-1));
        }

        [TestMethod]
        public void TestMethod10()
        {
            Assert.AreEqual("MMMDCCXLIX", new LCIntegerToRoman.Program().IntToRoman(3749));
        }

    }
}
