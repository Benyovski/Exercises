namespace LCRegexMatchingTests
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsFalse(new LCRegexMatching.Program().IsMatchBeta("aa", "a"));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.IsTrue(new LCRegexMatching.Program().IsMatchBeta("aa", "a*"));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.IsTrue(new LCRegexMatching.Program().IsMatchBeta("ab", ".*"));
        }
    }
}
