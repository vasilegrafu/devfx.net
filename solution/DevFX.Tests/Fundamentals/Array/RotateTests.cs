using System.Linq;
using NUnit.Framework;

namespace DevFX.Fundamentals
{
    [TestFixture]
    public partial class ArrayExtenderTest
    {
        [TestCase(new int[] { 0, 1, 2, 3, 4, 5, 6, 7 }, 2, new int[] { 2, 3, 4, 5, 6, 7, 0, 1 })]
        public void RotateLeft(int[] array, int n, int[] expectedArray)
        {
            int[] resultedArray = array.RotateLeft(n);

            Assert.IsTrue(resultedArray.IsEqual(expectedArray));
        }

        [TestCase(new int[] { 0, 1, 2, 3, 4, 5, 6, 7 }, 2, new int[] { 6, 7, 0, 1, 2, 3, 4, 5 })]
        public void RotateRight(int[] array, int n, int[] expectedArray)
        {
            int[] resultedArray = array.RotateRight(n);

            Assert.IsTrue(resultedArray.IsEqual(expectedArray));
        }

        [TestCase(new int[] { 0, 1, 2, 3, 4, 5, 6, 7 }, 2, RotateDirection.Left, new int[] { 2, 3, 4, 5, 6, 7, 0, 1 })]
        [TestCase(new int[] { 0, 1, 2, 3, 4, 5, 6, 7 }, 2, RotateDirection.Right, new int[] { 6, 7, 0, 1, 2, 3, 4, 5 })]
        public void ElementAt(int[] array, int n, RotateDirection rotateDirection, int[] expectedArray)
        {
            int[] resultedArray = array.ForEach((p, i) => array.ElementAt(i, rotateDirection, n)).ToArray();

            Assert.IsTrue(resultedArray.IsEqual(expectedArray));
        }
    }
}