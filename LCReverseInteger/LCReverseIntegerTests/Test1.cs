namespace LCReverseIntegerTests
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(321, LCReverseInteger.Program.Reverse(123));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(-321, LCReverseInteger.Program.Reverse(-123));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(21, LCReverseInteger.Program.Reverse(120));
        }
    }
}
