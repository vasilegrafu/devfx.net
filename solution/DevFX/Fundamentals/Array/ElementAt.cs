using System;
using System.Collections.Generic;
using System.Linq;

namespace DevFX.Fundamentals
{
    public static partial class ArrayExtender
    {
        public static T ElementAt<T>(this T[] source, int index, RotateDirection rotateDirection, int n)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            if (index < 0)
                throw new ArgumentOutOfRangeException(nameof(index));

            if (n < 0)
                throw new ArgumentOutOfRangeException(nameof(n));

            if (rotateDirection == RotateDirection.Left)
            {
                int length = source.Length;
                return source[(index + n) % length];
            }
            else if (rotateDirection == RotateDirection.Right)
            {
                int length = source.Count();
                return source[(index + length - n) % length];
            }
            else
            {
                throw new NotImplementedException();
            }
        }


        public static T[] ElementsAt<T>(this T[] source, IEnumerable<int> indexes)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            if (indexes == null)
                throw new ArgumentNullException(nameof(indexes));

            T[] destination = new T[source.Length];
            int i = -1;
            foreach (int index in indexes)
            {
                i++;
                destination[i] = source[index];
            }
            return destination;
        }

        public static T[] ElementsAt<T>(this T[] source, IEnumerable<int> indexes, RotateDirection rotateDirection, int n)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            if (indexes == null)
                throw new ArgumentNullException(nameof(indexes));

            if (n < 0)
                throw new ArgumentOutOfRangeException(nameof(n));

            T[] destination = new T[source.Length];
            int i = -1;
            foreach (int index in indexes)
            {
                i++;
                destination[i] = source.ElementAt(index, rotateDirection, n);
            }
            return destination;
        }
    }
}
