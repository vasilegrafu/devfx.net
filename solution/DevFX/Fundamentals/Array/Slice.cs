using System;

namespace DevFX.Fundamentals
{
    public static partial class ArrayExtender
    {
        public static T[] Slice<T>(this T[] source, int? start = null, int? end = null)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            if (start == null)
                start = 0;

            if (end == null)
                end = source.Length;
            
            T[] destination = new T[end.Value - start.Value];
            System.Array.Copy(source, start.Value, destination, 0, destination.Length);
            return destination;
        }
    }
}
