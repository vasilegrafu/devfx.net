using System;
using System.Collections.Generic;

namespace DevFX.Fundamentals
{
    public static partial class EnumerableExtender
    {
        public static int IndexWhere<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            if (predicate == null)
                throw new ArgumentNullException(nameof(predicate));

            int i = -1;
            foreach (T element in source)
            {
                if (predicate(element))
                {
                    return i;
                }
            }
            return -1;
        }

        public static IEnumerable<int> IndexesWhere<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            if (predicate == null)
                throw new ArgumentNullException(nameof(predicate));

            int i = -1;
            foreach (T element in source)
            {
                i++;
                if (predicate(element))
                {
                    yield return i;
                }
            }
        }
   }
}