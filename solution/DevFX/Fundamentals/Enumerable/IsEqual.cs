using System;
using System.Collections.Generic;
using System.Linq;

namespace DevFX.Fundamentals
{
    public static partial class EnumerableExtender
    {
        public static bool IsEqual<T>(this IEnumerable<T> source1, IEnumerable<T> source2)
        {
            if (source1 == null)
                throw new ArgumentNullException(nameof(source1));

            if (source2 == null)
                throw new ArgumentNullException(nameof(source2));

            if (source1.Count() != source2.Count())
                throw new ArgumentException();

            using (IEnumerator<T> element1 = source1.GetEnumerator())
            {
                using (IEnumerator<T> element2 = source2.GetEnumerator())
                {
                    while (element1.MoveNext() && element2.MoveNext())
                    {
                        bool isEqual = element1.Current.Equals(element2.Current);
						if(!isEqual)
                        {
                            return false;
                        }
                    }
                }
            }

            return true;
        }

        public static bool IsEqual<T, TResult>(this IEnumerable<T> source1, IEnumerable<T> source2, Func<T, TResult> selector)
        {
            if (source1 == null)
                throw new ArgumentNullException(nameof(source1));

            if (source2 == null)
                throw new ArgumentNullException(nameof(source2));

            if (source1.Count() != source2.Count())
                throw new ArgumentException();

            using (IEnumerator<T> element1 = source1.GetEnumerator())
            {
                using (IEnumerator<T> element2 = source2.GetEnumerator())
                {
                    while (element1.MoveNext() && element2.MoveNext())
                    {
                        bool isEqual = selector(element1.Current).Equals(selector(element2.Current));
                        if (!isEqual)
                        {
                            return false;
                        }
                    }
                }
            }

            return true;
        }

        public static bool IsEqual<T1, T2, TResult>(this IEnumerable<T1> source1, IEnumerable<T2> source2, Func<T1, TResult> selector1, Func<T2, TResult> selector2)
        {
            if (source1 == null)
                throw new ArgumentNullException(nameof(source1));

            if (source2 == null)
                throw new ArgumentNullException(nameof(source2));

            if (source1.Count() != source2.Count())
                throw new ArgumentException();

            using (IEnumerator<T1> element1 = source1.GetEnumerator())
            {
                using (IEnumerator<T2> element2 = source2.GetEnumerator())
                {
                    while (element1.MoveNext() && element2.MoveNext())
                    {
                        bool isEqual = selector1(element1.Current).Equals(selector2(element2.Current));
                        if (!isEqual)
                        {
                            return false;
                        }
                    }
                }
            }

            return true;
        }
    }
}
