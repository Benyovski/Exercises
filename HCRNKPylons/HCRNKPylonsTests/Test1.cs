namespace HCRNKPylonsTests
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<int> cities = [0, 1, 1, 1, 1, 0];
            int range = 2;
            int expected = 2;
            Assert.AreEqual(expected, HCRNKPylons.Program.Pylons(range, cities));
        }

        [TestMethod]
        public void TestMethod2()
        {
            List<int> cities = [0, 1, 1, 1, 0, 0, 0];
            int range = 3;
            int expected = -1;
            Assert.AreEqual(expected, HCRNKPylons.Program.Pylons(range, cities));
        }

        [TestMethod]
        public void TestMethod3()
        {
            List<int> cities = [ 0, 1, 0, 0, 0, 1, 1, 1, 1, 1 ];
            int range = 3;
            int expected = 3;
            Assert.AreEqual(expected, HCRNKPylons.Program.Pylons(range, cities));
        }
    }
}
