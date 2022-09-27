using System;

namespace dotRandom
{
    public static partial class DotRandom
    {
        public static int RandomIntBetween(int a, int b)
        {
            var randGen = new Random();

            return randGen.Next(a, b);
        }

        public static int RandomInt()
        {
            return RandomIntBetween(int.MinValue, int.MaxValue);
        }

        public static int RandomPostitiveInt()
        {
            return RandomIntBetween(0, int.MaxValue);
        }

        public static int RandomNegativeInt()
        {
            return RandomIntBetween(int.MinValue, 0);
        }

        public static short RandomShortBetween(short a, short b)
        {
            var randGen = new Random();

            return (short)randGen.Next(a, b);
        }

        public static short RandomShort()
        {
            return RandomShortBetween(short.MinValue, short.MaxValue);
        }

        public static short RandomPostitiveShort()
        {
            return RandomShortBetween(0, short.MaxValue);
        }

        public static short RandomNegativeShort()
        {
            return RandomShortBetween(short.MinValue, 0);
        }

        public static byte RandomByteBetween(byte a, byte b)
        {
            var randGen = new Random();

            return (byte)randGen.Next(a, b);
        }

        public static byte RandomByte()
        {
            return RandomByteBetween(byte.MinValue, byte.MaxValue);
        }
    }
}