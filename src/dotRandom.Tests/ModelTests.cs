namespace dotRandom.Tests
{
    public class TestModel
    {
        public int Id { get; set; }

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string Description {  get; set; } = string.Empty;

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}"; 
            }
        }
    }

    public class ModelTests
    {
        [Fact]
        public void ShouldCreateObjectIgnoringReadOnlyProps()
        {
            // Arrange

            // Act
            var generatedTestObject = DotRandom.GenerateRandom<TestModel>();

            // Assert
            generatedTestObject.ShouldSatisfyAllConditions(
                    x => x.FirstName.ShouldNotBeEmpty(),
                    x => x.LastName.ShouldNotBeEmpty()
                );
        }
    }
}
