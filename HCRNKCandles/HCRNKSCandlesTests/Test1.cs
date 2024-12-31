namespace HCRNKSCandlesTests
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<int> candles = new List<int> { 4, 4, 4, 4, 4 };
            Assert.AreEqual(5, HCRNKCandles.Program.BirthdayCakeCandles(candles));
        }

        [TestMethod]
        public void TestMethod2()
        {
            List<int> candles = new List<int> { 4, 4, 1, 3 };
            Assert.AreEqual(2, HCRNKCandles.Program.BirthdayCakeCandles(candles));
        }
    }
}
