using System;

namespace DevFX.Fundamentals
{
    public static partial class ArrayExtender
    {
        public static T[] Prepend<T>(this T[] source, T element)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            T[] destination = new T[source.Length + 1];
            destination[0] = element;
            source.CopyTo(destination, 1);
            return destination;
        }

        public static T[] Prepend<T>(this T[] source, T[] elements)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            if (elements == null)
                throw new ArgumentNullException(nameof(elements));

            T[] destination = new T[source.Length + elements.Length];
            elements.CopyTo(destination, 0);
            source.CopyTo(destination, elements.Length);
            return destination;
        }
    }
}