namespace LCStringToIntegerTests
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(42, new LCStringToInteger.Program().MyAtoi("42"));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(-42, new LCStringToInteger.Program().MyAtoi(" -042"));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(1337, new LCStringToInteger.Program().MyAtoi("1337c0d3"));
        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual(0, new LCStringToInteger.Program().MyAtoi("0-1"));
        }

        [TestMethod]
        public void TestMethod5()
        {
            Assert.AreEqual(0, new LCStringToInteger.Program().MyAtoi("words and 987"));
        }

        [TestMethod]
        public void TestMethod6()
        {
            Assert.AreEqual(int.MinValue, new LCStringToInteger.Program().MyAtoi("-91283472332"));
        }

        [TestMethod]
        public void TestMethod7()
        {
            Assert.AreEqual(int.MaxValue, new LCStringToInteger.Program().MyAtoi("20000000000000000000"));
        }

        [TestMethod]
        public void TestMethod8()
        {
            Assert.AreEqual(int.MaxValue, new LCStringToInteger.Program().MyAtoi("1234567890123456789012345678901234567890"));
        }
    }
}
