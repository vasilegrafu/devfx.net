using System;

namespace DevFX.Fundamentals
{
    public static partial class ArrayExtender
    {
        public static T[] RotateLeft<T>(this T[] source, int n)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            if (n < 0)
                throw new ArgumentOutOfRangeException(nameof(n));

            int length = source.Length;

            T[] destination = new T[length];
            System.Array.Copy(source, n, destination, 0, length - n);
            System.Array.Copy(source, 0, destination, length - n, n);
            return destination;
        }

        public static T[] RotateRight<T>(this T[] source, int n)
        {
            return source.RotateLeft(source.Length - n);
        }
    }
}
