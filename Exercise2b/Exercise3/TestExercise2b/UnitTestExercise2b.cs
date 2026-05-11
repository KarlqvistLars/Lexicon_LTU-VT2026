using Exercise2b;

namespace TestExercise2b
{
    public class UnitTestExercise2b
    {
        [Fact]
        public void TestToString1()
        {
            // Arrange
            Person person = new Person("John", "Doe", 30);

            // Act
            string result = person.ToString();

            // Assert

            Assert.Equal("John Doe is 30 years old.", result);
        }

        [Fact]
        public void TestToString2()
        {
            // Arrange
            Person person = new Person("Sune", "Svensson", 30, 500);

            // Act
            string result = person.ToString();

            // Assert

            Assert.Equal("Sune Svensson receives 500,00 dollars.", result);
        }

        [Fact]
        public void TestToString3()
        {
            // Arrange
            Person person = new Person("Stina", "Svensson", 30, 500);
            person.IncreaseSalary(10);
            // Act
            string result = person.ToString();
            // Assert
            Assert.Equal("Stina Svensson receives 550,00 dollars.", result);
        }

        [Fact]
        public void TestToString4()
        {
            // Arrange

            // Act

            // Assert

        }

        //[Fact]
        //public void TestConsoleInputOutput()
        //{
        //    // Arrange
        //    var originalOut = Console.Out;
        //    var originalIn = Console.In;
        //    var persons = new List<Person>();

        //    using var output = new StringWriter();
        //    using var input = new StringReader("S Svensson 30 300\n");
        //    Console.SetIn(input);
        //    var cmdArgs = Console.ReadLine().Split();

        //    Console.WriteLine(string.Join(" ", cmdArgs));
        //    var person = new Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]), decimal.Parse(cmdArgs[3]));

        //    try
        //    {
        //        Console.SetIn(input);

        //        // Act
        //        persons.Add(person);

        //        Console.SetOut(output);
        //        // Assert
        //        var result = output.ToString();

        //        Assert.Equal("Stina Svensson receives 500,00 dollars.", result);
        //    }
        //    finally
        //    {
        //        Console.SetOut(originalOut);
        //        Console.SetIn(originalIn);
        //
        //  }
        //}
    }
}