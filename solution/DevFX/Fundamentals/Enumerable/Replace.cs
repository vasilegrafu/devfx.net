using System;
using System.Collections.Generic;

namespace DevFX.Fundamentals
{
    public static partial class EnumerableExtender
    {
        public static IEnumerable<T> Replace<T>(this IEnumerable<T> source, Func<T, bool> predicate, T replacer)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            foreach (T element in source)
            {
                if (predicate(element))
                {
                    yield return element;
                }
                else
                {
                    yield return replacer;
                }
            }
        }

        public static IEnumerable<T> Replace<T>(this IEnumerable<T> source, IEnumerable<bool> booleans, T replacer)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            if (booleans == null)
                throw new ArgumentNullException(nameof(booleans));

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
                        else
                        {
                            yield return replacer;
                        }
                    }
                }
            }
        }
    }
}