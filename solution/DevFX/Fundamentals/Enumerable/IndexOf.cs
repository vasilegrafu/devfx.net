using System;
using System.Collections.Generic;

namespace DevFX.Fundamentals
{
    public static partial class EnumerableExtender
    {
        public static int IndexOf<T>(this IEnumerable<T> source, T element)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            int i = -1;
            foreach (T element2 in source)
            {
                i++;
                if (element2.Equals(element))
                {
                    return i;
                }
            }

            return (-1);
        }

        public static IEnumerable<int> IndexesOf<T>(this IEnumerable<T> source, IEnumerable<T> elements)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            if (elements == null)
                throw new ArgumentNullException(nameof(elements));

            foreach (T element in elements)
            {
                yield return source.IndexOf(element);
            }
        }
    }
}