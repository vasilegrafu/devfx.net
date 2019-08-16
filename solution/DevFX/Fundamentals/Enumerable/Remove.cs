using System;
using System.Collections.Generic;
using System.Linq;

namespace DevFX.Fundamentals
{
    public static partial class EnumerableExtender
    {
        public static IEnumerable<T> Remove<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            if (predicate == null)
                throw new ArgumentNullException(nameof(predicate));

            foreach (T element in source)
            {
                if (!predicate(element))
                {
                    yield return element;
                }
            }
        }

        public static IEnumerable<T> RemoveAt<T>(this IEnumerable<T> source, int index)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            if (index < 0)
                throw new ArgumentNullException(nameof(index));

            int i = -1;
            foreach (T element in source)
            {
                i++;
                if (i == index)
                {
                    continue;
                }
                else
                {
                    yield return element;
                }
            }
        }

        public static IEnumerable<T> RemoveAt<T>(this IEnumerable<T> source, int index, int count)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            if (index < 0)
                throw new ArgumentNullException(nameof(index));

            if (count < 0)
                throw new ArgumentNullException(nameof(count));

            int i = -1;
            foreach (T element in source)
            {
                i++;
                if ((index <= i) && (i < (index + count)))
                {
                    continue;
                }
                else
                {
                    yield return element;
                }
            }
        }

        public static IEnumerable<T> RemoveAt<T>(this IEnumerable<T> source, IEnumerable<int> indexes)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            if (indexes == null)
                throw new ArgumentNullException(nameof(indexes));

            int i = -1;
            foreach (T element in source)
            {
                i++;
                if (indexes.Contains(i))
                {
                    continue;
                }
                else
                {
                    yield return element;
                }
            }
        }


        public static IEnumerable<T> RemoveRange<T>(this IEnumerable<T> source, int? start, int? end)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            if (start == null)
                start = 0;

            if (end == null)
                end = source.Count();

            int i = -1;
            foreach (T element in source)
            {
                i++;
                if ((start.Value <= i) && (i < end.Value))
                {
                    continue;
                }
                else
                {
                    yield return element;
                }
            }
        }
    }
}