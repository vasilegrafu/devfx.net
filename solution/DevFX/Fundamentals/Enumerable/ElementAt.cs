using System;
using System.Collections.Generic;
using System.Linq;

namespace DevFX.Fundamentals
{
    public static partial class EnumerableExtender
    {
        public static T ElementAt<T>(this IEnumerable<T> source, int index, RotateDirection rotateDirection, int n)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            if (index < 0)
                throw new ArgumentOutOfRangeException(nameof(index));

            if (n < 0)
                throw new ArgumentOutOfRangeException(nameof(n));

            if (rotateDirection == RotateDirection.Left)
            {
                int length = source.Count();
                return source.ElementAt((index + n) % length);
            }
            else if (rotateDirection == RotateDirection.Right)
            {
                int length = source.Count();
                return source.ElementAt((index + length - n) % length);
            }
            else
            {
                throw new NotImplementedException();
            }
        }
        
        
        public static IEnumerable<T> ElementsAt<T>(this IEnumerable<T> source, IEnumerable<int> indexes)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            if (indexes == null)
                throw new ArgumentNullException(nameof(indexes));

            foreach (int index in indexes)
            {
                yield return source.ElementAt(index);
            }
        }

        public static IEnumerable<T> ElementsAt<T>(this IEnumerable<T> source, IEnumerable<int> indexes, RotateDirection rotateDirection, int n)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            if (indexes == null)
                throw new ArgumentNullException(nameof(indexes));

            if (n < 0)
                throw new ArgumentOutOfRangeException(nameof(n));

            foreach (int index in indexes)
            {
                yield return source.ElementAt(index, rotateDirection, n);
            }
        }
    }
}
