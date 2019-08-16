using System;
using System.Collections.Generic;

namespace DevFX.Fundamentals
{
    public static partial class EnumerableExtender
    {
        public static IEnumerable<T> Append<T>(this IEnumerable<T> source, T element)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            foreach (T element2 in source)
            {
                yield return element2;
            }
            yield return element;
        }

        public static IEnumerable<T> Append<T>(this IEnumerable<T> source, IEnumerable<T> elements)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            if (elements == null)
                throw new ArgumentNullException(nameof(elements));

            foreach (T element in source)
            {
                yield return element;
            }
            foreach (T element in elements)
            {
                yield return element;
            }
        }
    }
}