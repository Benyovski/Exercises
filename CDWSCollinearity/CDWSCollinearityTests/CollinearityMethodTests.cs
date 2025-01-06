namespace CDWSCollinearityTests
{
    [TestClass]
    public sealed class CollinearityMethodTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(true, CDWSCollinearity.Program.Collinearity(0, 0, 0, 0));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(true, CDWSCollinearity.Program.Collinearity(1, 1, 1, 1));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(true, CDWSCollinearity.Program.Collinearity(1, -2, -2, 4));
        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual(false, CDWSCollinearity.Program.Collinearity(1, 1, 6, 1));
        }

        [TestMethod]
        public void TestMethod5()
        {
            Assert.AreEqual(false, CDWSCollinearity.Program.Collinearity(1, 2, 1, -2));
        }

        [TestMethod]
        public void TestMethod6()
        {
            Assert.AreEqual(false, CDWSCollinearity.Program.Collinearity(4, 4, 0, 4));
        }
    }
}
