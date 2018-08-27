using System;
using System.Collections.Generic;

namespace DevFX.Fundamentals
{
    public static partial class EnumerableExtender
    {
        public static IEnumerable<T> Repeat<T>(this IEnumerable<T> source, int n)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            int i = -1;
            while(i <= n)
            {
                i++;
                foreach (T element in source)
                {
                    yield return element;
                }
            }
        }
    }
}