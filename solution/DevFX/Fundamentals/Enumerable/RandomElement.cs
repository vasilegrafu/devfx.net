using System;
using System.Collections.Generic;
using System.Linq;

namespace DevFX.Fundamentals
{
    public static partial class EnumerableExtender
    {
        public static T RandomElement<T>(this IEnumerable<T> source)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            Random random = new Random(Guid.NewGuid().GetHashCode());
            int length = source.Count();
            return source.ElementAt(random.Next(0, length));
        }

        public static IEnumerable<T> RandomElements<T>(this IEnumerable<T> source, int n)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            Random random = new Random(Guid.NewGuid().GetHashCode());
            int length = source.Count();
            for (int i = 0; i < n; i++)
            {
                yield return source.ElementAt(random.Next(0, length));
            }
        }
    }
}