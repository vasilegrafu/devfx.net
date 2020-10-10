using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;

using DevFX.Fundamentals;

namespace DevFX.Fundamentals.Samples
{
    public partial class EnumerableExtenderTest
    {
        public static void RotateLeft()
        {
            IEnumerable<int> enumerable = new int[] { 0, 1, 2, 3, 4, 5, 6, 7 };
            int n = 2;
            IEnumerable<int> expectedEnumerable = new int[] { 2, 3, 4, 5, 6, 7, 0, 1 };
            IEnumerable<int> resultedEnumerable = enumerable.RotateLeft(n);

            Debug.Assert(resultedEnumerable.IsEqual(expectedEnumerable));
        }

        public static void RotateRight()
        {
            IEnumerable<int> enumerable = new int[] { 0, 1, 2, 3, 4, 5, 6, 7 };
            int n = 2;
            IEnumerable<int> expectedEnumerable = new int[] { 6, 7, 0, 1, 2, 3, 4, 5 };
            IEnumerable<int> resultedEnumerable = enumerable.RotateRight(n);

            Debug.Assert(resultedEnumerable.IsEqual(expectedEnumerable));
        }

        public static void ElementAt()
        {
            {
                IEnumerable<int> enumerable = new int[] { 0, 1, 2, 3, 4, 5, 6, 7 };
                int n = 2;
                RotateDirection rotateDirection = RotateDirection.Left;
                IEnumerable<int> expectedEnumerable = new int[] { 2, 3, 4, 5, 6, 7, 0, 1 };
                IEnumerable<int> resultedEnumerable = enumerable.ForEach((p, i) => enumerable.ElementAt(i, rotateDirection, n));

                Debug.Assert(resultedEnumerable.IsEqual(expectedEnumerable));
            }

            {
                IEnumerable<int> enumerable = new int[] { 0, 1, 2, 3, 4, 5, 6, 7 };
                int n = 2;
                RotateDirection rotateDirection = RotateDirection.Right;
                IEnumerable<int> expectedEnumerable = new int[] { 6, 7, 0, 1, 2, 3, 4, 5 };
                IEnumerable<int> resultedEnumerable = enumerable.ForEach((p, i) => enumerable.ElementAt(i, rotateDirection, n));

                Debug.Assert(resultedEnumerable.IsEqual(expectedEnumerable));
            }
        }
    }
}