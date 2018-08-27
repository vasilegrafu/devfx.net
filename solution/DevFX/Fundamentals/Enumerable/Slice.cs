using System;
using System.Collections.Generic;
using System.Linq;

namespace DevFX.Fundamentals
{
    public static partial class EnumerableExtender
    {
        public static IEnumerable<T> Slice<T>(this IEnumerable<T> source, int? start = null, int? end = null)
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
                if (start <= i && i < end)
                {
                    yield return element;
                }
            }
        }
    }
}
