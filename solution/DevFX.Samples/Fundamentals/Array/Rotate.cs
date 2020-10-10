using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;

using DevFX.Fundamentals;

namespace DevFX.Fundamentals.Samples
{
    public partial class ArrayExtenderTest
    {
        public static void RotateLeft()
        {
            int[] array = new int[] { 0, 1, 2, 3, 4, 5, 6, 7 };
            int n = 2;
            int[] expectedArray = new int[] { 2, 3, 4, 5, 6, 7, 0, 1 };
            int[] resultedArray = array.RotateLeft(n);

            Debug.Assert(resultedArray.IsEqual(expectedArray));
        }

        public static void RotateRight()
        {
            int[] array = new int[] { 0, 1, 2, 3, 4, 5, 6, 7 };
            int n = 2;
            int[] expectedArray = new int[] { 6, 7, 0, 1, 2, 3, 4, 5 };
            int[] resultedArray = array.RotateRight(n);

            Debug.Assert(resultedArray.IsEqual(expectedArray));
        }

        public static void ElementAt()
        {
            {
                int[] array = new int[] { 0, 1, 2, 3, 4, 5, 6, 7 };
                int n = 2;
                RotateDirection rotateDirection = RotateDirection.Left;
                int[] expectedArray = new int[] { 2, 3, 4, 5, 6, 7, 0, 1 };
                int[] resultedArray = array.ForEach((p, i) => array.ElementAt(i, rotateDirection, n)).ToArray();

                Debug.Assert(resultedArray.IsEqual(expectedArray));
            }

            {
                int[] array = new int[] { 0, 1, 2, 3, 4, 5, 6, 7 };
                int n = 2;
                RotateDirection rotateDirection = RotateDirection.Right;
                int[] expectedArray = new int[] { 6, 7, 0, 1, 2, 3, 4, 5 };
                int[] resultedArray = array.ForEach((p, i) => array.ElementAt(i, rotateDirection, n)).ToArray();

                Debug.Assert(resultedArray.IsEqual(expectedArray));
            }
        }
    }
}