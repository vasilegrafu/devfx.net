using System;
using System.Collections.Generic;

namespace DevFX.Fundamentals
{
    public static partial class EnumerableExtender
    {
        public static IEnumerable<T> Insert<T>(this IEnumerable<T> source, int index, T element)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            if (index < 0)
                throw new ArgumentOutOfRangeException(nameof(index));

            int i = -1;
            foreach (T element2 in source)
            {
                i++;
                if (i == index)
                {
                    yield return element;
                }
                yield return element2;
            }
        }

        public static IEnumerable<T> Insert<T>(this IEnumerable<T> source, int index, IEnumerable<T> elements)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            if (index < 0)
                throw new ArgumentOutOfRangeException(nameof(index));

            if (elements == null)
                throw new ArgumentNullException(nameof(elements));

            int i = -1;
            foreach (T element2 in source)
            {
                i++;
                if (i == index)
                {
                    foreach (T element in elements)
                    {
                        yield return element;
                    }
                }
                yield return element2;
            }
        }
    }
}