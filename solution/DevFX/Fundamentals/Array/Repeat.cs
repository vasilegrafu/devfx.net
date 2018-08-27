using System;

namespace DevFX.Fundamentals
{
    public static partial class ArrayExtender
    {       
        public static T[] Repeat<T>(this T[] source, int n)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            T[] destination = new T[source.Length*n];
            for (int i = 0; i < n; i++)
            {
                source.CopyTo(destination, i*source.Length); 
            }
            return destination;
        }
    }
}