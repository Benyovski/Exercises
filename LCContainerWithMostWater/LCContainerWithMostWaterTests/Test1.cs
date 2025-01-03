namespace LCContainerWithMostWaterTests
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(49, new LCContainerWithMostWater.Program().MaxArea([1, 8, 6, 2, 5, 4, 8, 3, 7]));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(1, new LCContainerWithMostWater.Program().MaxArea([1, 1]));
        }
    }
}
