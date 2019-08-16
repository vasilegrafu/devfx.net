using System;
using System.Collections.Generic;
using System.Linq;

namespace DevFX.Fundamentals
{
    public static partial class EnumerableExtender
    {
        public static bool IsEmpty<T>(this IEnumerable<T> source)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            return !source.Any();
        }
    }
}