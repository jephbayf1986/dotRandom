namespace dotRandom.Tests
{
    public class NumericTests
    {
        [Fact]
        public void LongShouldTakeMaxAndMinPossibleValues()
        {
            // Arrange
            var resultList = new List<long>();

            // Act
            for (int i = 0; i < TestingSampleSize; i++)
                resultList.Add(DotRandom.RandomLongBetween(long.MinValue, long.MaxValue));

            // Assert
            resultList.All(x => x >= long.MinValue && x <= long.MaxValue)
                      .ShouldBeTrue();
        }

        [Theory]
        [InlineData(-100, 100)]
        [InlineData(-100000, 100000)]
        [InlineData(-1000000000, 1000000000)]
        public void LongShouldTakeSmallerValues(long minValue, long maxValue)
        {
            // Arrange
            var resultList = new List<long>();

            // Act
            for (int i = 0; i < TestingSampleSize; i++)
                resultList.Add(DotRandom.RandomLongBetween(minValue, maxValue));

            // Assert
            resultList.All(x => x >= minValue && x <= maxValue)
                      .ShouldBeTrue();
        }

        [Theory]
        [InlineData(-100, 100)]
        [InlineData(-100000, 100000)]
        [InlineData(-1000000000, 1000000000)]
        [InlineData(int.MinValue, 0)]
        [InlineData(0, int.MaxValue)]
        [InlineData(int.MinValue, int.MaxValue)]
        public void RandomIntBetweenShouldBeWithinRange(int minValue, int maxValue)
        {
            // Arrange
            var resultList = new List<int>();

            // Act
            for (int i = 0; i < TestingSampleSize; i++)
                resultList.Add(DotRandom.RandomIntBetween(minValue, maxValue));

            // Assert
            resultList.All(x => x >= minValue && x <= maxValue)
                      .ShouldBeTrue();
        }

        [Theory]
        [InlineData(-100, 100)]
        [InlineData(-1000, 1000)]
        [InlineData(-10000, 10000)]
        [InlineData(short.MinValue, 0)]
        [InlineData(0, short.MaxValue)]
        [InlineData(short.MinValue, short.MaxValue)]
        public void RandomShortBetweenShouldBeWithinRange(short minValue, short maxValue)
        {
            // Arrange
            var resultList = new List<short>();

            // Act
            for (int i = 0; i < TestingSampleSize; i++)
                resultList.Add(DotRandom.RandomShortBetween(minValue, maxValue));

            // Assert
            resultList.All(x => x >= minValue && x <= maxValue)
                      .ShouldBeTrue();
        }

        [Theory]
        [InlineData(1, 100)]
        [InlineData(100, 200)]
        [InlineData(byte.MinValue, 0)]
        [InlineData(0, byte.MaxValue)]
        [InlineData(byte.MinValue, byte.MaxValue)]
        public void RandomByteBetweenShouldBeWithinRange(byte minValue, byte maxValue)
        {
            // Arrange
            var resultList = new List<byte>();

            // Act
            for (int i = 0; i < TestingSampleSize; i++)
                resultList.Add(DotRandom.RandomByteBetween(minValue, maxValue));

            // Assert
            resultList.All(x => x >= minValue && x <= maxValue)
                      .ShouldBeTrue();
        }
    }
}