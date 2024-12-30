namespace LCMinMaxSumTests
{
    [TestClass]
    [DoNotParallelize]
    public sealed class Test1
    {
        private TextWriter originalOut = null!;
        private StringWriter sw = null!;

        [TestInitialize]
        public void SetOriginalConsoleOutput()

        {
            originalOut = Console.Out;
            sw = new StringWriter();
            Console.SetOut(sw);
        }

        [TestCleanup]
        public void RestoreOriginalConsoleOutput()

        {
            Console.SetOut(originalOut);
            sw.Flush();
            sw.Close();
            sw.Dispose();
        }

        [TestMethod]
        public void TestMethod1()
        {
            List<int> list = new List<int> { 1, 3, 5, 7, 9 };
            HCRNKMinMaxSum.Program.MinMaxSum(list);
            string expected = string.Format($"16 24{Environment.NewLine}");
            Assert.AreEqual(expected, sw.ToString());
        }

        [TestMethod]
        public void TestMethod2()
        {
            List<int> list = new List<int> { 1, 2, 3, 4, 5 };
            HCRNKMinMaxSum.Program.MinMaxSum(list);
            string expected = string.Format($"10 14{Environment.NewLine}");
            Assert.AreEqual(expected, sw.ToString());
        }

        [TestMethod]
        public void TestMethod3()
        {
            List<int> list = new List<int> { 396285104, 573261094, 759641832, 819230764, 364801279 };
            HCRNKMinMaxSum.Program.MinMaxSum(list);
            string expected = string.Format($"2093989309 2548418794{Environment.NewLine}");
            Assert.AreEqual(expected, sw.ToString());
        }
    }
}