using System;

namespace dotRandom
{
    public static partial class DotRandom
    {
        /// <summary>
        /// Random Date in the Past
        /// </summary>
        /// <param name="maxDaysInPast">Maximum days to go back (Default 100 days)</param>
        /// <returns>Date Time from past</returns>
        public static DateTime RandomDateInPast(int maxDaysInPast = 100)
        {
            var randGen = new Random();

            var daysInPast = randGen.Next(1, maxDaysInPast);

            return DateTime.Today.AddDays(0 - daysInPast)
                                 .WithRandomTime();
        }

        /// <summary>
        /// Random Date in the Future
        /// </summary>
        /// <param name="maxDaysInPast">Maximum days to go forward (Default 100 days)</param>
        /// <returns>Date Time from future</returns>
        public static DateTime RandomDateInFuture(int maxDaysInFuture = 100)
        {
            var randGen = new Random();

            var daysInFuture = randGen.Next(1, maxDaysInFuture);

            return DateTime.Today.AddDays(daysInFuture)
                                 .WithRandomTime();
        }

        /// <summary>
        /// Random Date in a Year
        /// </summary>
        /// <param name="year">Year to pick a date from</param>
        /// <returns>Date Time within Year</returns>
        public static DateTime RandomDateInYear(int year)
        {
            var randGen = new Random();

            var daysInYear = DateTime.IsLeapYear(year) ? 366 : 365;

            var randomDayInYear = randGen.Next(0, daysInYear);

            return new DateTime(year, 1, 1).AddDays(randomDayInYear)
                                           .WithRandomTime();
        }

        /// <summary>
        /// Same Date with Random Time
        /// </summary>
        /// <param name="dateTime">Date Time to change the time on</param>
        /// <returns>Date Time with different Time from input</returns>
        public static DateTime WithRandomTime(this DateTime dateTime)
        {
            return dateTime.Date.AddHours(RandomIntBetween(0, 23))
                                .AddMinutes(RandomIntBetween(0, 59))
                                .AddSeconds(RandomIntBetween(0, 59));
        }
    }
}