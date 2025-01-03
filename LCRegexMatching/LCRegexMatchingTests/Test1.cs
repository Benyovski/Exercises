namespace LCRegexMatchingTests
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsFalse(new LCRegexMatching.Program().IsMatch("aa", "a"));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.IsTrue(new LCRegexMatching.Program().IsMatch("aa", "a*"));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.IsTrue(new LCRegexMatching.Program().IsMatch("ab", ".*"));
        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.IsTrue(new LCRegexMatching.Program().IsMatch("aab", "c*a*b"));
        }

        [TestMethod]
        public void TestMethod5()
        {
            Assert.IsFalse(new LCRegexMatching.Program().IsMatch("mississippi", "mis*is*p*."));
        }
    }
}
