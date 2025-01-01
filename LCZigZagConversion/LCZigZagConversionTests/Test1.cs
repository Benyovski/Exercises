namespace LCZigZagConversionTests
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string s = "PAYPALISHIRING";
            int numRows = 3;
            string expected = "PAHNAPLSIIGYIR";
            string actual = LCZigZagConversion.Program.Convert(s, numRows);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string s = "PAYPALISHIRING";
            int numRows = 4;
            string expected = "PINALSIGYAHRPI";
            string actual = LCZigZagConversion.Program.Convert(s, numRows);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod3()
        {
            string s = "A";
            int numRows = 1;
            string expected = "A";
            string actual = LCZigZagConversion.Program.Convert(s, numRows);
            Assert.AreEqual(expected, actual);
        }
    }
}
