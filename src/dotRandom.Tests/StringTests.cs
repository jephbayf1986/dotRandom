namespace dotRandom.Tests
{
    public class StringTests
    {
        [Fact]
        public void ShouldDefaultTo50Long()
        {
            // Arrange
            var resultList = new List<string>();

            // Act
            for (int i = 0; i < TestingSampleSize; i++)
                resultList.Add(DotRandom.RandomString());

            // Assert
            resultList.All(x => x.Length == 50)
                      .ShouldBeTrue();
        }

        [Theory]
        [InlineData(10)]
        [InlineData(100)]
        [InlineData(1000)]
        public void ShouldBeLengthProvided(int length)
        {
            // Arrange
            var resultList = new List<string>();

            // Act
            for (int i = 0; i < TestingSampleSize; i++)
                resultList.Add(DotRandom.RandomString(length));

            // Assert
            resultList.All(x => x.Length == length)
                      .ShouldBeTrue();
        }

        [Fact]
        public void ShouldBeLowerCaseWhenRequested()
        {
            // Arrange
            var resultList = new List<string>();

            // Act
            for (int i = 0; i < TestingSampleSize; i++)
                resultList.Add(DotRandom.RandomLowerCaseString());

            // Assert
            resultList.All(x => x == x.ToLower())
                      .ShouldBeTrue();
        }

        [Fact]
        public void ShouldBeUpperCaseWhenRequested()
        {
            // Arrange
            var resultList = new List<string>();

            // Act
            for (int i = 0; i < TestingSampleSize; i++)
                resultList.Add(DotRandom.RandomUpperCaseString());

            // Assert
            resultList.All(x => x == x.ToUpper())
                      .ShouldBeTrue();
        }

        [Fact]
        public void ShouldGenerateLoremIpsumParagraph()
        {
            // Arrange

            // Act
            var lorumText = DotRandom.LoremIpsumText();

            // Assert
            lorumText.ShouldNotBeEmpty();
        }
    }
}