using System.Collections.Generic;
using NUnit.Framework;

namespace DevFX.Fundamentals
{
    [TestFixture]
    public partial class EnumerableExtenderTest
    {
        [TestCase(new int[] { 0, 1, 2, 3, 4 }, new int[] { 0, 1, 4, 9, 16 })]
        public void ForEach(IEnumerable<int> enumerable, IEnumerable<int> expectedEnumerable)
        {
            IEnumerable<int> resultedEnumerable = enumerable.ForEach((p) => p*p);

            Assert.IsTrue(resultedEnumerable.IsEqual(expectedEnumerable));
        }

        [TestCase(new int[] { 0, 1, 2, 3, 4 }, new int[] { 0, 2, 6, 12, 20 })]
        public void ForEachWithIndex(IEnumerable<int> enumerable, IEnumerable<int> expectedEnumerable)
        {
            IEnumerable<int> resultedEnumerable = enumerable.ForEach((p, i) => p * p + i);

            Assert.IsTrue(resultedEnumerable.IsEqual(expectedEnumerable));
        }
    }
}