namespace LCTwoSumTests
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] nums = new int[] { 2, 7, 11, 15 };
            int desiredSum = 9;
            int[] solution = LCTwoSum.Program.TwoSum(nums, desiredSum);
            CollectionAssert.AreEqual(new int[] { 0, 1 }, solution);
        }
    }
}
