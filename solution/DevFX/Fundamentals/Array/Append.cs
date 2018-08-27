using System;

namespace DevFX.Fundamentals
{
    public static partial class ArrayExtender
    {
        public static T[] Append<T>(this T[] source, T element)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            T[] destination = new T[source.Length + 1];
            source.CopyTo(destination, 0);
            destination[source.Length] = element;
            return destination;
        }

        public static T[] Append<T>(this T[] source, T[] elements)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            if (elements == null)
                throw new ArgumentNullException(nameof(elements));

            T[] destination = new T[source.Length + elements.Length];
            source.CopyTo(destination, 0);
            elements.CopyTo(destination, source.Length);
            return destination;
        }
    }
}