using System;
using System.Linq;

namespace dotRandom
{
    public static partial class DotRandom
    {
        /// <summary>
        /// Random String
        /// </summary>
        /// <param name="length">Length of Output String (Default 50)</param>
        /// <returns>A string comprimising randomized A-z characters</returns>
        public static string RandomString(int length = 50)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            var random = new Random();

            return new string(Enumerable.Repeat(chars + chars.ToLower(), length)
                                        .Select(s => s[random.Next(s.Length)])
                                        .ToArray());

        }

        /// <summary>
        /// Random Upper Case String
        /// </summary>
        /// <param name="length">Length of Output String (Default 50)</param>
        /// <returns>A string comprimising randomized A-Z characters</returns>
        public static string RandomUpperCaseString(int length = 50)
        {
            return RandomString(length).ToUpper();
        }

        /// <summary>
        /// Random Lower Case String
        /// </summary>
        /// <param name="length">Length of Output String (Default 50)</param>
        /// <returns>A string comprimising randomized a-z characters</returns>
        public static string RandomLowerCaseString(int length = 50)
        {
            return RandomString(length).ToLower();
        }
    }
}