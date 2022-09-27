namespace dotRandom.Tests
{
    public class StringTests
    {
        [Fact]
        public void ShouldDefaultTo50Long()
        {
            // Arrange

            // Act
            var result = DotRandom.RandomString();

            // Assert
            result.Length.ShouldBe(50);
        }

        [Theory]
        [InlineData(10)]
        [InlineData(100)]
        [InlineData(1000)]
        public void ShouldBeLengthProvided(int length)
        {
            // Arrange

            // Act
            var result = DotRandom.RandomString(length);

            // Assert
            result.Length.ShouldBe(length);
        }

        [Theory]
        [InlineData(10)]
        [InlineData(100)]
        [InlineData(1000)]
        public void ShouldBeLowerCaseWhenRequested(int length)
        {
            // Arrange

            // Act
            var result = DotRandom.RandomLowerCaseString(length);

            // Assert
            result.ShouldBe(result.ToLower());
        }

        [Theory]
        [InlineData(10)]
        [InlineData(100)]
        [InlineData(1000)]
        public void ShouldBeUpperCaseWhenRequested(int length)
        {
            // Arrange

            // Act
            var result = DotRandom.RandomUpperCaseString(length);

            // Assert
            result.ShouldBe(result.ToUpper());
        }
    }
}