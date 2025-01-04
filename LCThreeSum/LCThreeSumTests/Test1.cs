namespace LCThreeSumTests
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] nums = [ -1, 0, 1, 2, -1, -4 ];
            IList<IList<int>> expected = new List<IList<int>>
            {
                new List<int> { -1, -1, 2 },
                new List<int> { -1, 0, 1 }
            };
            var actual = new LCThreeSum.Program().ThreeSum(nums);
            var sortedExpected = new HashSet<string>(expected.Select(triplet => string.Join(",", triplet.OrderBy(x => x))));
            var sortedActual = new HashSet<string>(actual.Select(triplet => string.Join(",", triplet.OrderBy(x => x))));
            Assert.IsTrue(sortedExpected.SetEquals(sortedActual),"Triplets differ when ignoring order.");
        }

        [TestMethod]
        public void TestMethod2()
        {
            int[] nums = [];
            IList<IList<int>> result = new List<IList<int>>();
            CollectionAssert.AreEqual(result.ToList(), new LCThreeSum.Program().ThreeSum(nums).ToList());
        }

        [TestMethod]
        public void TestMethod3()
        {
            int[] nums = [0];
            IList<IList<int>> result = new List<IList<int>>();
            CollectionAssert.AreEqual(result.ToList(), new LCThreeSum.Program().ThreeSum(nums).ToList());
        }

        [TestMethod]
        public void TestMethod4()
        {
            int[] nums = [0, 0, 0];
            IList<IList<int>> result = new List<IList<int>>()
            {
                new List<int>() { 0, 0, 0 }
            };
            CollectionAssert.AreEqual(result.ToList(), new LCThreeSum.Program().ThreeSum(nums).ToList());
        }

        [TestMethod]
        public void TestMethod5()
        {
            int[] nums = [0, 0, 0, 0];
            IList<IList<int>> result = new List<IList<int>>()
            {
                new List<int>() { 0, 0, 0 }
            };
            CollectionAssert.AreEqual(result.ToList(), new LCThreeSum.Program().ThreeSum(nums).ToList());
        }

        [TestMethod]
        public void TestMethod6()
        {
            int[] nums = [-1, 0, 1, 2, -1, -4, -2, -3, 3, 0, 4];
            IList<IList<int>> expected = new List<IList<int>>
            {
                new List<int>(){ -4, 0, 4 },
                new List<int>(){ -4, 1, 3 },
                new List<int>(){ -3, -1, 4 },
                new List<int>(){ -3, 0, 3 },
                new List<int>(){ -3, 1, 2 },
                new List<int>(){ -2, -1, 3 },
                new List<int>(){ -2, 0, 2 },
                new List<int>(){ -1, -1, 2 },
                new List<int>(){ -1, 0, 1 }
            };
            var actual = new LCThreeSum.Program().ThreeSum(nums);
            var sortedExpected = new HashSet<string>(expected.Select(triplet => string.Join(",", triplet.OrderBy(x => x))));
            var sortedActual = new HashSet<string>(actual.Select(triplet => string.Join(",", triplet.OrderBy(x => x))));
            Assert.IsTrue(sortedExpected.SetEquals(sortedActual), "Triplets differ when ignoring order.");
        }
    }
}
