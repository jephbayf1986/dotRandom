using System;

namespace dotRandom
{
    public static partial class DotRandom
    {
        /// <summary>
        /// Random Boolean
        /// </summary>
        /// <returns>Either True or False value</returns>
        public static bool RandomBool()
        {
            var randGen = new Random();

            return randGen.Next(0, 1) == 0;
        }
    }
}