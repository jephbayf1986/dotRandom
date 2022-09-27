namespace dotRandom.Tests
{
    public class DateTests
    {
        private const int numberOfTests = 1000;

        [Fact]
        public void DateInPastMustBeInPast()
        {
            // Arrange
            var resultList = new List<DateTime>();

            // Act
            for (int i = 0; i < numberOfTests; i++)
                resultList.Add(DotRandom.RandomDateInPast());

            // Assert
            resultList.All(x => x < DateTime.Today)
                      .ShouldBeTrue();
        }

        [Fact]
        public void DateInPastWhenDefaultMustBeWithin100Days()
        {
            // Arrange
            var resultList = new List<DateTime>();

            // Act
            for (int i = 0; i < numberOfTests; i++)
                resultList.Add(DotRandom.RandomDateInPast());

            // Assert
            resultList.All(x => x >= DateTime.Today.AddDays(-100))
                      .ShouldBeTrue();
        }

        [Theory]
        [InlineData(10)]
        [InlineData(100)]
        [InlineData(1000)]
        public void DateInPastMustBeWithinRange(int maxDaysInPast)
        {
            // Arrange
            var resultList = new List<DateTime>();

            // Act
            for (int i = 0; i < numberOfTests; i++)
                resultList.Add(DotRandom.RandomDateInPast(maxDaysInPast));

            // Assert
            resultList.All(x => x >= DateTime.Today.AddDays(0 - maxDaysInPast))
                      .ShouldBeTrue();
        }

        [Fact]
        public void DateInPastWith1DayRangeMustBeYesterday()
        {
            // Arrange

            // Act
            var result = DotRandom.RandomDateInPast(1);

            // Assert
            result.Date.ShouldBe(DateTime.Today.AddDays(-1));
        }

        [Fact]
        public void DateInFutureMustBeInFuture()
        {
            // Arrange
            var resultList = new List<DateTime>();

            // Act
            for (int i = 0; i < numberOfTests; i++)
                resultList.Add(DotRandom.RandomDateInFuture());

            // Assert
            resultList.All(x => x >= DateTime.Today.AddDays(1))
                      .ShouldBeTrue();
        }

        [Fact]
        public void DateInFutureWhenDefaultMustBeWithin100Days()
        {
            // Arrange
            var resultList = new List<DateTime>();

            // Act
            for (int i = 0; i < numberOfTests; i++)
                resultList.Add(DotRandom.RandomDateInFuture());

            // Assert
            resultList.All(x => x < DateTime.Today.AddDays(100))
                      .ShouldBeTrue();
        }

        [Theory]
        [InlineData(10)]
        [InlineData(100)]
        [InlineData(1000)]
        public void DateInFutureMustBeWithinRangePlus1(int maxDaysInFuture)
        {
            // Arrange
            var resultList = new List<DateTime>();

            // Act
            for (int i = 0; i < numberOfTests; i++)
                resultList.Add(DotRandom.RandomDateInFuture(maxDaysInFuture));

            // Assert
            resultList.All(x => x < DateTime.Today.AddDays(maxDaysInFuture + 1))
                      .ShouldBeTrue();
        }

        [Fact]
        public void DateInFutureWith1DayRangeMustBeTomorrow()
        {
            // Arrange

            // Act
            var result = DotRandom.RandomDateInFuture(1);

            // Assert
            result.Date.ShouldBe(DateTime.Today.AddDays(1));
        }

        [Theory]
        [InlineData(2020)]
        [InlineData(2022)]
        public void DateInYearMustBeWithinYear(int year)
        {
            // Arrange
            var resultList = new List<DateTime>();

            // Act
            for (int i = 0; i < numberOfTests; i++)
                resultList.Add(DotRandom.RandomDateInYear(year));

            // Assert
            resultList.All(x => x.Year == year)
                      .ShouldBeTrue();
        }
    }
}