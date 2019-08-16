using System;

namespace DevFX.Fundamentals
{
    public static partial class StringExtender
    {      
        public static string Repeat(this string source, int n)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            string destination = string.Empty;
            for (int i = 0; i < n; i++)
            {
                destination += source;
            }
            return destination;
        }
    }
}