namespace RangeIndexArrayTests
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] array = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
            Index index = 3;
            Index indexFromEnd = ^3;
            Range range = index..indexFromEnd;
            int[] subArray = array[range];
            int[] expectedArray = [4, 5, 6, 7];
            CollectionAssert.AreEqual(expectedArray, subArray);
        }
    }
}
