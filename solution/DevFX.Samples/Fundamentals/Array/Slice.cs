using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;

using DevFX.Fundamentals;

namespace DevFX.Fundamentals.Samples
{
    public partial class ArrayExtenderTest
    {
        public void Slice()
        {
            {
                int[] array = new int[] { 0, 1, 2, 3, 4, 5, 6, 7 };
                int? start = 0;
                int? end = 3;
                int[] expectedArray = new int[] { 0, 1, 2 };
                int[] resultedArray = array.Slice(start, end);

                Debug.Assert(resultedArray.IsEqual(expectedArray));
            }

            {
                int[] array = new int[] { 0, 1, 2, 3, 4, 5, 6, 7 };
                int? start = 1;
                int? end = 3;
                int[] expectedArray = new int[] { 1, 2 };
                int[] resultedArray = array.Slice(start, end);

                Debug.Assert(resultedArray.IsEqual(expectedArray));
            }

            {
                int[] array = new int[] { 0, 1, 2, 3, 4, 5, 6, 7 };
                int? start = 7;
                int? end = null;
                int[] expectedArray = new int[] { 7 };
                int[] resultedArray = array.Slice(start, end);

                Debug.Assert(resultedArray.IsEqual(expectedArray));
            }

            {
                int[] array = new int[] { 0, 1, 2, 3, 4, 5, 6, 7 };
                int? start = null;
                int? end = 8;
                int[] expectedArray = new int[] { 0, 1, 2, 3, 4, 5, 6, 7 };
                int[] resultedArray = array.Slice(start, end);

                Debug.Assert(resultedArray.IsEqual(expectedArray));
            }
        }
    }
}