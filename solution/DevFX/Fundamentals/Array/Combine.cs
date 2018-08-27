using System;

namespace DevFX.Fundamentals
{
    public static partial class ArrayExtender
    {
        public static TResult[] Combine<T1, T2, TResult>(this T1[] source1, T2[] source2, Func<T1, T2, TResult> combiner)
        {
            if (source1 == null)
                throw new ArgumentNullException(nameof(source1));

            if (source2 == null)
                throw new ArgumentNullException(nameof(source2));

            if (source1.Length != source2.Length)
                throw new ArgumentException();

            TResult[] destination = new TResult[source1.Length];
            int i = -1;
            while(i < source1.Length)
            {
                i++;
                destination[i] = combiner(source1[i], source2[i]);
            }
            return destination;
        }

        public static TResult[] Combine<T1, T2, TResult>(this T1[] source1, T2[] source2, Func<T1, T2, int, TResult> combiner)
        {
            if (source1 == null)
                throw new ArgumentNullException(nameof(source1));

            if (source2 == null)
                throw new ArgumentNullException(nameof(source2));

            if (source1.Length != source2.Length)
                throw new ArgumentException();

            TResult[] destination = new TResult[source1.Length];
            int i = -1;
            while (i < source1.Length)
            {
                i++;
                destination[i] = combiner(source1[i], source2[i], i);
            }
            return destination;
        }
    }
}