namespace CDWSFindTheOddIntTests
{
    [TestClass]
    public sealed class FindTheOddIntegerTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(5, CDWSFindTheOddInt.Program.FindIt([1, 1, 2, 2, 3, 3, 4, 4, 5]));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(5, CDWSFindTheOddInt.Program.FindIt([5]));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(4, CDWSFindTheOddInt.Program.FindIt([1, 2, 2, 3, 3, 3, 4, 3, 3, 3, 2, 2, 1]));
        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual(0, CDWSFindTheOddInt.Program.FindIt([0, 1, 0, 1, 0]));
        }

        [TestMethod]
        public void TestMethod5()
        {
            Assert.AreEqual(5, CDWSFindTheOddInt.Program.FindIt([20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5]));
        }
    }
}
