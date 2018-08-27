using System;
using System.Collections.Generic;
using System.Linq;

namespace DevFX.Fundamentals
{
    public static partial class EnumerableExtender
    {
        public static IEnumerable<IEnumerable<T>> Split<T>(this IEnumerable<T> source, int n)
        {
            return source.Select((element, index) => new { index, element })
                         .GroupBy(x => x.index % n)
                         .Select(x => x.Select(y => y.element));
        }
    }
}