using System;
using System.Collections.Generic;

namespace DevFX.Fundamentals
{
    public static partial class EnumerableExtender
    {
        public static IEnumerable<TResult> ForEach<T, TResult>(this IEnumerable<T> source, Func<T, TResult> action)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            if (action == null)
                throw new ArgumentNullException(nameof(action));

            foreach (T element in source)
            {
                yield return action(element);
            }
        }

        public static IEnumerable<TResult> ForEach<T, TResult>(this IEnumerable<T> source, Func<T, int, TResult> action)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            if (action == null)
                throw new ArgumentNullException(nameof(action));

            int i = -1;
            foreach (T element in source)
            {
                i++;
                yield return action(element, i);
            }
        }
    }
}