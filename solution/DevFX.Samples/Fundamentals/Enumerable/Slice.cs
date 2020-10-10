using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;

using DevFX.Fundamentals;

namespace DevFX.Fundamentals.Samples
{
    public partial class EnumerableExtenderTest
    {
        public void Slice()
        {
            {
                IEnumerable<int> enumerable = new int[] { 0, 1, 2, 3, 4, 5, 6, 7 };
                int? start = 0;
                int? end = 3;
                IEnumerable<int> expectedEnumerable = new int[] { 0, 1, 2 };
                IEnumerable<int> resultedEnumerable = enumerable.Slice(start, end);

                Debug.Assert(resultedEnumerable.IsEqual(expectedEnumerable));
            }

            {
                IEnumerable<int> enumerable = new int[] { 0, 1, 2, 3, 4, 5, 6, 7 };
                int? start = 1;
                int? end = 3;
                IEnumerable<int> expectedEnumerable = new int[] { 1, 2 };
                IEnumerable<int> resultedEnumerable = enumerable.Slice(start, end);

                Debug.Assert(resultedEnumerable.IsEqual(expectedEnumerable));
            }

            {
                IEnumerable<int> enumerable = new int[] { 0, 1, 2, 3, 4, 5, 6, 7 };
                int? start = 7;
                int? end = null;
                IEnumerable<int> expectedEnumerable = new int[] { 7 };
                IEnumerable<int> resultedEnumerable = enumerable.Slice(start, end);

                Debug.Assert(resultedEnumerable.IsEqual(expectedEnumerable));
            }

            {
                IEnumerable<int> enumerable = new int[] { 0, 1, 2, 3, 4, 5, 6, 7 };
                int? start = null;
                int? end = 8;
                IEnumerable<int> expectedEnumerable = new int[] { 0, 1, 2, 3, 4, 5, 6, 7 };
                IEnumerable<int> resultedEnumerable = enumerable.Slice(start, end);

                Debug.Assert(resultedEnumerable.IsEqual(expectedEnumerable));
            }
        }
    }
}