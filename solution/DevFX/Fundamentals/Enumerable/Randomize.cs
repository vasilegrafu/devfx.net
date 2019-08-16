using System;
using System.Collections.Generic;
using System.Linq;

namespace DevFX.Fundamentals
{
    public static partial class EnumerableExtender
    {
        public static IEnumerable<T> Randomize<T>(this IEnumerable<T> source)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            Random random = new Random(Guid.NewGuid().GetHashCode());
            T[] elements = source.ToArray();
            for (int i = 0; i < elements.Length; i++)
            {
                int random_i = random.Next(i, elements.Length);
                yield return elements[random_i];
                elements[random_i] = elements[i];
            }
        }
    }
}