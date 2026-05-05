using System;
using System.IO;
using System.Reflection;
using Xunit;
using static Exercise2.Program;

namespace Exercise2
{
    public class UnitTest2
    {
        public class BioMenuTests : IDisposable
        {
            private readonly TextWriter _originalOut;
            private readonly TextReader _originalIn;

            public BioMenuTests()
            {
                _originalOut = Console.Out;
                _originalIn = Console.In;
            }

            public void Dispose()
            {
                Console.SetOut(_originalOut);
                Console.SetIn(_originalIn);
            }

            [Fact]
            public void PrintBioMenu_WhenInvalidInput_PrintsErrorMessage()
            {
                // Arrange
                var originalOut = Console.Out;
                var originalIn = Console.In;

                using var output = new StringWriter();
                using var input = new StringReader("9\n");

                try
                {
                    Console.SetOut(output);
                    Console.SetIn(input);

                    // Act
                    Program.PrintBioMenu();

                    // Assert
                    string result = output.ToString();

                    Assert.Contains("Välkommen på Bio!", result);
                    Assert.Contains("Ange menyval:", result);
                    Assert.Contains("Felaktigt menyval. Försök igen.", result);
                }
                finally
                {
                    Console.SetOut(originalOut);
                    Console.SetIn(originalIn);
                }
            }

            [Fact]
            public void PrintMenuEnkelbiljett_PrintsPrices()
            {
                // Arrange
                using var output = new StringWriter();
                using var input = new StringReader("1\n");
                Console.SetOut(output);
                Console.SetIn(input);

                // Act
                Program.PrintMenuEnkelbiljett();

                // Assert
                var result = output.ToString();
                Assert.Contains("Ungdom(under 20 år):", result);
                Assert.Contains("80kr", result);
                Assert.Contains("Pensionär(över 64år):", result);
                Assert.Contains("90kr", result);
                Assert.Contains("Vuxen:", result);
                Assert.Contains("120kr", result);
            }

            [Fact]
            public void PrintMenuGruppbiljett_()
            {
                // Arrange
                using var output = new StringWriter();
                using var input = new StringReader("1\n");
                Console.SetOut(output);
                Console.SetIn(input);

                // Act
                Program.PrintMenuEnkelbiljett();

                // Assert
                var result = output.ToString();
                Assert.Contains("Ungdom(under 20 år):", result);
                Assert.Contains("80kr", result);
                Assert.Contains("Pensionär(över 64år):", result);
                Assert.Contains("90kr", result);
                Assert.Contains("Vuxen:", result);
                Assert.Contains("120kr", result);
            }

            [Fact]
            public void PrintBioMenu_WhenInput_1()
            {
                // Arrange
                var originalOut = Console.Out;
                var originalIn = Console.In;

                using var output = new StringWriter();
                using var inputData = new StringReader("1\n");

                try
                {
                    Console.SetOut(output);
                    Console.SetIn(inputData);

                    // Act
                    Program.PrintBioMenu("1");

                    // Assert
                    string result = output.ToString();

                    Assert.Contains("Enkelbiljett", result);
                    Assert.Contains("Ungdom(under 20 år):", result);
                    Assert.Contains("80kr", result);
                    Assert.Contains("Pensionär(över 64år):", result);
                    Assert.Contains("90kr", result);
                    Assert.Contains("Vuxen:", result);
                    Assert.Contains("120kr", result);
                }
                finally
                {
                    Console.SetOut(originalOut);
                    Console.SetIn(originalIn);
                }
            }
        }
    }
}