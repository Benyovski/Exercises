namespace LCLongestCommonPrefixTests
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("fl", new LCLongestCommonPrefix.Program().LongestCommonPrefix(["flower", "flow", "flight"]));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual("", new LCLongestCommonPrefix.Program().LongestCommonPrefix(["dog", "racecar", "car"]));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual("a", new LCLongestCommonPrefix.Program().LongestCommonPrefix(["a"]));
        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual("", new LCLongestCommonPrefix.Program().LongestCommonPrefix([]));
        }

        [TestMethod]
        public void TestMethod5()
        {
            Assert.AreEqual("alf", new LCLongestCommonPrefix.Program().LongestCommonPrefix(["alfesliugfhbsaoil", "alfhpjppl"]));
        }
    }
}
