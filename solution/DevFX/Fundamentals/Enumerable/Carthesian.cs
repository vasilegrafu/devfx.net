using System;
using System.Collections.Generic;

namespace DevFX.Fundamentals
{
    public static partial class EnumerableExtender
    {
        public static IEnumerable<TResult> Carthesian<T1, T2, TResult>(this IEnumerable<T1> source1, IEnumerable<T2> source2, Func<T1, T2, TResult> selector)
        {
            if (source1 == null)
                throw new ArgumentNullException(nameof(source1));

            if (source2 == null)
                throw new ArgumentNullException(nameof(source2));

            if (selector == null)
                throw new ArgumentNullException(nameof(selector));

            foreach (T1 element1 in source1)
            {
                foreach (T2 element2 in source2)
                {
                    yield return selector(element1, element2);
                }
            }
        }

        public static IEnumerable<TResult> Carthesian<T1, T2, TResult>(this IEnumerable<T1> source1, IEnumerable<T2> source2, Func<T1, T2, int, int, TResult> selector)
        {
            if (source1 == null)
                throw new ArgumentNullException(nameof(source1));

            if (source2 == null)
                throw new ArgumentNullException(nameof(source2));

            if (selector == null)
                throw new ArgumentNullException(nameof(selector));

            int i = -1;
            foreach (T1 element1 in source1)
            {
                i++;
                int j = -1;
                foreach (T2 element2 in source2)
                {
                    j++;
                    yield return selector(element1, element2, i, j);
                }
            }
        }
    }
}