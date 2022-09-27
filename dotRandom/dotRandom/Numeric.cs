using System;

namespace dotRandom
{
    public static partial class DotRandom
    {
        /// <summary>
        /// Random Long Between
        /// </summary>
        /// <param name="minValue">Minimum Value</param>
        /// <param name="maxValue">Maximum Value</param>
        /// <returns>An 64-bit Integer falling between the values provided</returns>
        public static long RandomLongBetween(long minValue, long maxValue)
        {
            if (maxValue <= int.MaxValue && minValue >= int.MinValue && minValue < maxValue)
                return RandomIntBetween((int)minValue, (int)maxValue);

            var randGen = new Random();

            ulong valueRange = (ulong)(maxValue - minValue);

            ulong randomUlong;

            do
            {
                byte[] randomByteArray = new byte[8];

                randGen.NextBytes(randomByteArray);

                randomUlong = (ulong)BitConverter.ToInt64(randomByteArray, 0);

            } while (randomUlong > CheckModulus(valueRange));

            return (long)(randomUlong % valueRange) + minValue;
        }

        private static ulong CheckModulus(ulong range)
            => ulong.MaxValue - ((ulong.MaxValue % range) + 1) % range;

        /// <summary>
        /// Random Long
        /// </summary>
        /// <returns>A 64-bit Integer falling in the range between -9,223,372,036,854,775,808 and 9,223,372,036,854,775,807</returns>
        public static long RandomLong()
            => RandomLongBetween(long.MinValue, long.MaxValue);

        /// <summary>
        /// Random Positive Long
        /// </summary>
        /// <returns>A 64-bit Integer falling in the range between 0 and 9,223,372,036,854,775,807</returns>
        public static long RandomPostitiveLong()
            => RandomLongBetween(0, long.MaxValue);

        /// <summary>
        /// Random Negative Long
        /// </summary>
        /// <returns>A 64-bit Integer falling in the range between -9,223,372,036,854,775,808 and 0</returns>
        public static long RandomNegativeLong()
            => RandomLongBetween(long.MinValue, 0);

        /// <summary>
        /// Random Int Between
        /// </summary>
        /// <param name="minValue">Minimum Value</param>
        /// <param name="maxValue">Maximum Value</param>
        /// <returns>An 32-bit Integer falling between the values provided</returns>
        public static int RandomIntBetween(int minValue, int maxValue)
        {
            var randGen = new Random();

            return randGen.Next(minValue, maxValue);
        }

        /// <summary>
        /// Random Int
        /// </summary>
        /// <returns>A 32-bit Integer falling in the range between -2,147,483,648 and 2,147,483,647</returns>
        public static int RandomInt()
            => RandomIntBetween(int.MinValue, int.MaxValue);

        /// <summary>
        /// Random Positive Int
        /// </summary>
        /// <returns>A 32-bit Integer falling in the range between 0 and 2,147,483,647</returns>
        public static int RandomPostitiveInt()
            => RandomIntBetween(0, int.MaxValue);

        /// <summary>
        /// Random Negative Int
        /// </summary>
        /// <returns>A 32-bit Integer falling in the range between -2,147,483,648 and 0</returns>
        public static int RandomNegativeInt() 
            => RandomIntBetween(int.MinValue, 0);

        /// <summary>
        /// Random Short Between
        /// </summary>
        /// <param name="minValue">Minimum Value</param>
        /// <param name="maxValue">Maximum Value</param>
        /// <returns>An 16-bit Integer falling between the values provided</returns>
        public static short RandomShortBetween(short minValue, short maxValue)
            => (short)RandomIntBetween(minValue, maxValue);

        /// <summary>
        /// Random Short
        /// </summary>
        /// <returns>A 16-bit Integer falling in the range between -32,768 and 32,767</returns>
        public static short RandomShort()
            => (short)RandomIntBetween(short.MinValue, short.MaxValue);

        /// <summary>
        /// Random Positive Short
        /// </summary>
        /// <returns>A 16-bit Integer falling in the range between 0 and 32,767</returns>
        public static short RandomPostitiveShort()
            => (short)RandomIntBetween(0, short.MaxValue);

        /// <summary>
        /// Random Negative Short
        /// </summary>
        /// <returns>A 16-bit Integer falling in the range between -32,768 and 0</returns>
        public static short RandomNegativeShort()
            => (short)RandomIntBetween(short.MinValue, 0);

        /// <summary>
        /// Random Byte Between
        /// </summary>
        /// <param name="minValue">Minimum Value</param>
        /// <param name="maxValue">Maximum Value</param>
        /// <returns>An 8-bit Integer falling between the values provided</returns>
        public static byte RandomByteBetween(byte minValue, byte maxValue)
            => (byte)RandomIntBetween(minValue, maxValue);

        /// <summary>
        /// Random Byte
        /// </summary>
        /// <returns>A 8-bit Integer falling in the range between 0 and 255</returns>
        public static byte RandomByte()
            => (byte)RandomIntBetween(byte.MinValue, byte.MaxValue);
    }
}