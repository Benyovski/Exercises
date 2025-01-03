namespace LCPalindromeNumberTests
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(LCPalindromeNumber.Program.IsPalindrome(121));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.IsFalse(LCPalindromeNumber.Program.IsPalindrome(-121));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.IsFalse(LCPalindromeNumber.Program.IsPalindrome(10));
        }
    }
}
