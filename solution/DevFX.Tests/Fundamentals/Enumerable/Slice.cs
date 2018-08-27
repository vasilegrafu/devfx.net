using System.Collections.Generic;
using NUnit.Framework;

namespace DevFX.Fundamentals
{
    [TestFixture]
    public partial class EnumerableExtenderTest
    {
        [TestCase(new int[] { 0, 1, 2, 3, 4, 5, 6, 7 }, 0, 3, new int[] { 0, 1, 2 })]
        [TestCase(new int[] { 0, 1, 2, 3, 4, 5, 6, 7 }, 1, 3, new int[] { 1, 2 })]
        [TestCase(new int[] { 0, 1, 2, 3, 4, 5, 6, 7 }, 7, null, new int[] { 7 })]
        [TestCase(new int[] { 0, 1, 2, 3, 4, 5, 6, 7 }, null, 8, new int[] { 0, 1, 2, 3, 4, 5, 6, 7 })]
        public void Slice(IEnumerable<int> enumerable, int? start, int? end, IEnumerable<int> expectedEnumerable)
        {
            IEnumerable<int> resultedEnumerable = enumerable.Slice(start, end);

            Assert.IsTrue(resultedEnumerable.IsEqual(expectedEnumerable));
        }
    }
}