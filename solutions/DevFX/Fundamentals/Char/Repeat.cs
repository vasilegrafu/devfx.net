using System;

namespace DevFX.Fundamentals
{
    public static partial class CharExtender
    {      
        public static string Repeat(this char source, int n)
        {
            string destination = string.Empty;
            for (int i = 0; i < n; i++)
            {
                destination += source;
            }
            return destination;
        }
    }
}