using System;

namespace dotRandom
{
    public static partial class DotRandom
    {
        public static DateTime RandomDateInPast(int maxDaysInPast = 100)
        {
            var randGen = new Random();

            var daysInPast = randGen.Next(1, maxDaysInPast);

            return DateTime.Now.AddDays(0 - daysInPast);
        }

        public static DateTime RandomDateInFuture(int maxDaysInFuture = 100)
        {
            var randGen = new Random();

            var daysInPast = randGen.Next(1, maxDaysInFuture);

            return DateTime.Now.AddDays(daysInPast);
        }
    }
}