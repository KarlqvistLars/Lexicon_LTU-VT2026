using Exercise3;

namespace TestExercise3
{
    public class UnitTestExercise3
    {
        [Fact]
        public void TestToString()
        {
            // Arrange
            Person person = new Person("John", "Doe", 30);

            // Act
            string result = person.ToString();

            // Assert

            Assert.Equal("John Doe is 30 years old.", result);
        }
    }
}