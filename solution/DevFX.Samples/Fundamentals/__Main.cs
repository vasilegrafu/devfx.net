using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;

namespace DevFX.Samples
{
    public class __Main
    {
        static void Main(string[] args)
        {
            DevFX.Fundamentals.Samples.ArrayExtenderTest.RotateLeft();
            DevFX.Fundamentals.Samples.ArrayExtenderTest.RotateRight();
            DevFX.Fundamentals.Samples.ArrayExtenderTest.ElementAt();

            DevFX.Fundamentals.Samples.EnumerableExtenderTest.RotateLeft();
            DevFX.Fundamentals.Samples.EnumerableExtenderTest.RotateRight();
            DevFX.Fundamentals.Samples.EnumerableExtenderTest.ElementAt();

            DevFX.Fundamentals.Samples.EnumerableExtenderTest.ForEach();
            DevFX.Fundamentals.Samples.EnumerableExtenderTest.ForEachWithIndex();
        }   
    }
}
