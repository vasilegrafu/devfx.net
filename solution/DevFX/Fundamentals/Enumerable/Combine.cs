using System;
using System.Collections.Generic;
using System.Linq;

namespace DevFX.Fundamentals
{
    public static partial class EnumerableExtender
    {
        public static IEnumerable<TResult> Combine<T1, T2, TResult>(this IEnumerable<T1> source1, IEnumerable<T2> source2, Func<T1, T2, TResult> combiner)
        {
            if (source1 == null)
                throw new ArgumentNullException(nameof(source1));

            if (source2 == null)
                throw new ArgumentNullException(nameof(source2));

            if(source1.Count() != source2.Count())
                throw new ArgumentException();

            using (IEnumerator<T1> element1 = source1.GetEnumerator())
            {
                using (IEnumerator<T2> element2 = source2.GetEnumerator())
                {
                    while (element1.MoveNext() && element2.MoveNext())
                    {
                        yield return combiner(element1.Current, element2.Current);
                    }
                }
            }
        }

        public static IEnumerable<TResult> Combine<T1, T2, TResult>(this IEnumerable<T1> source1, IEnumerable<T2> source2, Func<T1, T2, int, TResult> combiner)
        {
            if (source1 == null)
                throw new ArgumentNullException(nameof(source1));

            if (source2 == null)
                throw new ArgumentNullException(nameof(source2));

            if (source1.Count() != source2.Count())
                throw new ArgumentException();

            int i = -1;
            using (IEnumerator<T1> element1 = source1.GetEnumerator())
            {
                using (IEnumerator<T2> element2 = source2.GetEnumerator())
                {
                    while (element1.MoveNext() && element2.MoveNext())
                    {
                        i++;
                        yield return combiner(element1.Current, element2.Current, i);
                    }
                }
            }
        }
    }
}