using System;

namespace dotRandom
{
    public static partial class DotRandom
    {
        public static bool RandomBool()
        {
            var randGen = new Random();

            return randGen.Next(0, 1) == 0;
        }
    }
}