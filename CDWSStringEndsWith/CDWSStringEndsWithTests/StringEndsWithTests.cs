namespace CDWSStringEndsWithTests
{
    [TestClass]
    public sealed class StringEndsWithTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(CDWSStringEndsWith.Program.Solution("abc", "bc"));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.IsFalse(CDWSStringEndsWith.Program.Solution("abc", "d"));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.IsTrue(CDWSStringEndsWith.Program.Solution("samruai", "ai"));
        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.IsFalse(CDWSStringEndsWith.Program.Solution("sumo", "omo"));
        }

        [TestMethod]
        public void TestMethod5()
        {
            Assert.IsTrue(CDWSStringEndsWith.Program.Solution("sumo", "sumo"));
        }

        [TestMethod]
        public void TestMethod6()
        {
            Assert.IsFalse(CDWSStringEndsWith.Program.Solution("this", "fails "));
        }

        [TestMethod]
        public void TestMethod7()
        {
            Assert.IsTrue(CDWSStringEndsWith.Program.Solution("this", ""));
        }
    }
}
