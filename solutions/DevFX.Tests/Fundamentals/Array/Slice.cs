using NUnit.Framework;

namespace DevFX.Fundamentals
{
    [TestFixture]
    public partial class ArrayExtenderTest
    {
        [TestCase(new int[] { 0, 1, 2, 3, 4, 5, 6, 7 }, 0, 3, new int[] { 0, 1, 2 })]
        [TestCase(new int[] { 0, 1, 2, 3, 4, 5, 6, 7 }, 1, 3, new int[] { 1, 2 })]
        [TestCase(new int[] { 0, 1, 2, 3, 4, 5, 6, 7 }, 7, null, new int[] { 7 })]
        [TestCase(new int[] { 0, 1, 2, 3, 4, 5, 6, 7 }, null, 8, new int[] { 0, 1, 2, 3, 4, 5, 6, 7 })]
        public void Slice(int[] array, int? start, int? end, int[] expectedArray)
        {
            int[] resultedArray = array.Slice(start, end);

            Assert.IsTrue(resultedArray.IsEqual(expectedArray));
        }
    }
}