using System;
using System.Collections.Generic;
using System.Linq;

namespace DevFX.Fundamentals
{
    public enum RotateDirection
    {
        Left,
        Right
    }

    public static partial class EnumerableExtender
    {
        public static IEnumerable<T> RotateLeft<T>(this IEnumerable<T> source, int n)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            if (n < 0)
                throw new ArgumentOutOfRangeException(nameof(n));

            foreach (T element in source.Skip(n))
            {
                yield return element;
            }
            foreach (T element in source.Take(n))
            {
                yield return element;
            }
        }

        public static IEnumerable<T> RotateRight<T>(this IEnumerable<T> source, int n)
        {
            return source.RotateLeft(source.Count() - n);
        }
    }
}
