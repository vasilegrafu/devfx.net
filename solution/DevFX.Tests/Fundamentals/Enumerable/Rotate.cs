using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace DevFX.Fundamentals
{
    [TestFixture]
    public partial class EnumerableExtenderTest
    {
        [TestCase(new int[] { 0, 1, 2, 3, 4, 5, 6, 7 }, 2, new int[] { 2, 3, 4, 5, 6, 7, 0, 1 })]
        public void RotateLeft(IEnumerable<int> enumerable, int n, IEnumerable<int> expectedEnumerable)
        {
            IEnumerable<int> resultedEnumerable = enumerable.RotateLeft(n);

            Assert.IsTrue(resultedEnumerable.IsEqual(expectedEnumerable));
        }

        [TestCase(new int[] { 0, 1, 2, 3, 4, 5, 6, 7 }, 2, new int[] { 6, 7, 0, 1, 2, 3, 4, 5 })]
        public void RotateRight(IEnumerable<int> enumerable, int n, IEnumerable<int> expectedEnumerable)
        {
            IEnumerable<int> resultedEnumerable = enumerable.RotateRight(n);

            Assert.IsTrue(resultedEnumerable.IsEqual(expectedEnumerable));
        }

        [TestCase(new int[] { 0, 1, 2, 3, 4, 5, 6, 7 }, 2, RotateDirection.Left, new int[] { 2, 3, 4, 5, 6, 7, 0, 1 })]
        [TestCase(new int[] { 0, 1, 2, 3, 4, 5, 6, 7 }, 2, RotateDirection.Right, new int[] { 6, 7, 0, 1, 2, 3, 4, 5 })]
        public void ElementAt(IEnumerable<int> enumerable, int n, RotateDirection rotateDirection, IEnumerable<int> expectedEnumerable)
        {
            IEnumerable<int> resultedEnumerable = enumerable.ForEach((p, i) => enumerable.ElementAt(i, rotateDirection, n));

            Assert.IsTrue(resultedEnumerable.IsEqual(expectedEnumerable));
        }
    }
}