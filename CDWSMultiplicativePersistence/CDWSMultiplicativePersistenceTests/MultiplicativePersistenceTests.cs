namespace CDWSMultiplicativePersistenceTests
{
    [TestClass]
    public sealed class MultiplicativePersistenceTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(0, CDWSMultiplicativePersistence.Program.Persistence(4));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(3, CDWSMultiplicativePersistence.Program.Persistence(39));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(4, CDWSMultiplicativePersistence.Program.Persistence(999));
        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual(2, CDWSMultiplicativePersistence.Program.Persistence(25));
        }
    }
}
