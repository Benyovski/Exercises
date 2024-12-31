namespace LCLongestPalindromicSubstringTests
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string s = "babad";
            Assert.AreEqual("aba", LCLongestPalindromicSubstring.Program.LongestPalindrome(s));
        }

        [TestMethod]
        public void TestMethod2()
        {
            string s = "cbbd";
            string expected = "bb";
            Assert.AreEqual("bb", LCLongestPalindromicSubstring.Program.LongestPalindrome(s));
        }

        [TestMethod]
        public void TestMethod3()
        {
            string s = "s";
            string expected = "s";
            Assert.AreEqual("s", LCLongestPalindromicSubstring.Program.LongestPalindrome(s));
        }

        [TestMethod]
        public void TestMethod4()
        {
            string s = "bb";
            string expected = "bb";
            Assert.AreEqual("bb", LCLongestPalindromicSubstring.Program.LongestPalindrome(s));
        }

        [TestMethod]
        public void TestMethod5()
        {
            string s = "ac";
            string expected = "a";
            Assert.AreEqual("a", LCLongestPalindromicSubstring.Program.LongestPalindrome(s));
        }

        [TestMethod]
        public void TestMethod6()
        {
            string s = "abb";
            string expected = "bb";
            Assert.AreEqual("bb", LCLongestPalindromicSubstring.Program.LongestPalindrome(s));
        }
    }
}
