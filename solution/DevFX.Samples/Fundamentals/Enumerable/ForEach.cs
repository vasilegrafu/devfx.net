using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;

using DevFX.Fundamentals;

namespace DevFX.Fundamentals.Samples
{
    public partial class EnumerableExtenderTest
    {
        public static void ForEach()
        {
            IEnumerable<int> enumerable = new int[] { 0, 1, 2, 3, 4 };
            IEnumerable<int> expectedEnumerable = new int[] { 0, 1, 4, 9, 16 };
            IEnumerable<int> resultedEnumerable = enumerable.ForEach((p) => p*p);

            Debug.Assert(resultedEnumerable.IsEqual(expectedEnumerable));
        }

        public static void ForEachWithIndex()
        {
            IEnumerable<int> enumerable = new int[] { 0, 1, 2, 3, 4 };
            IEnumerable<int> expectedEnumerable = new int[] { 0, 2, 6, 12, 20 };
            IEnumerable<int> resultedEnumerable = enumerable.ForEach((p, i) => p * p + i);

            Debug.Assert(resultedEnumerable.IsEqual(expectedEnumerable));
        }
    }
}