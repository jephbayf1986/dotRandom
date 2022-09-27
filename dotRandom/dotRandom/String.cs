using System;
using System.Linq;

namespace dotRandom
{
    public static partial class DotRandom
    {
        public static string RandomString(int length = 50)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            var random = new Random();

            return new string(Enumerable.Repeat(chars + chars.ToLower(), length)
                                        .Select(s => s[random.Next(s.Length)])
                                        .ToArray());

        }

        public static string RandomUpperCaseString(int length = 50)
        {
            return RandomString(length).ToUpper();
        }

        public static string RandomLowerCaseString(int length = 50)
        {
            return RandomString(length).ToLower();
        }
    }
}