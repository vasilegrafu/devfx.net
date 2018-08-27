using System;

namespace DevFX.Fundamentals
{
    public static partial class ArrayExtender
    {
        public static TResult[] ForEach<T, TResult>(this T[] source, Func<T, TResult> action)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            if (action == null)
                throw new ArgumentNullException(nameof(action));

            TResult[] destination = new TResult[source.Length];
            int i = -1;
            foreach (T element in source)
            {
                i++;
                destination[i] = action(element);
            }
            return destination;
        }
        
        public static TResult[] ForEach<T, TResult>(this T[] source, Func<T, int, TResult> action)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            if (action == null)
                throw new ArgumentNullException(nameof(action));

            TResult[] destination = new TResult[source.Length];
            int i = -1;
            foreach (T element in source)
            {
                i++;
                destination[i] = action(element, i);
            }
            return destination;
        }
    }
}