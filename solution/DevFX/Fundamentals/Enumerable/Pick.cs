using System;
using System.Collections.Generic;
using System.Linq;

namespace DevFX.Fundamentals
{
    public static partial class EnumerableExtender
    {
        public static IEnumerable<T> PickWhere<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            if (predicate == null)
                throw new ArgumentNullException(nameof(predicate));

            foreach (T element in source)
            {
                if (predicate(element))
                {
                    yield return element;
                }
            }
        }

        public static IEnumerable<T> Pick<T>(this IEnumerable<T> source, IEnumerable<bool> booleans)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            if (booleans == null)
                throw new ArgumentNullException(nameof(booleans));

            if (source.Count() != booleans.Count())
                throw new ArgumentException();

            using (IEnumerator<T> element = source.GetEnumerator())
            {
                using (IEnumerator<bool> boolean = booleans.GetEnumerator())
                {
                    while (element.MoveNext() && boolean.MoveNext())
                    {
                        if (boolean.Current)
                        {
                            yield return element.Current;
                        }
                    }
                }
            }
        }
    }
}