namespace LCMedianOfTwoSortedArraysTests
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] nums1 = [1, 3];
            int[] nums2 = [2];
            double expected = 2.0;
            double actual = LCMedianOfTwoSortedArrays.Program.FindMedianSortedArrays(nums1, nums2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int[] nums1 = [1, 2];
            int[] nums2 = [3, 4];
            double expected = 2.5;
            double actual = LCMedianOfTwoSortedArrays.Program.FindMedianSortedArrays(nums1, nums2);
            Assert.AreEqual(expected, actual);
        } 
    }
}
