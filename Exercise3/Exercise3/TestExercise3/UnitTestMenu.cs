using Exercise3.UtilitesClasses;

namespace Exercise3.Tests


{
    public class UnitTestMenu
    {
        [Fact]
        static public void TestMainMenu()
        {
            // Arrange
            var originalIn = Console.In;
            var originalOut = Console.Out;

            var input = new StringReader("0\n\n");
            var output = new StringWriter();
            Console.SetIn(input);
            Console.SetOut(output);

            try
            {
                // Act
                MenuHandler.MenuMain();

                // Hämtar allt som skrivits till console
                string result = output.ToString();

                // Assert
                Assert.Contains("1. Lägg till fordon\r\n", result);
                Assert.Contains("2. Ta bort fordon\r\n", result);
                Assert.Contains("3. Visa fordon\r\n", result);
                Assert.Contains("4. Hämta fordon från fil\r\n", result);
                Assert.Contains("0. Avsluta\r\n", result);
            }
            finally
            {
                Console.SetIn(originalIn);
                Console.SetOut(originalOut);
            }
        }

        //[Fact]
        //static public void TestMenuAddVehicle()
        //{
        //    // Arrange
        //    var originalIn = Console.In;
        //    var originalOut = Console.Out;

        //    using var input = new StringReader("0\n");
        //    using var output = new StringWriter();

        //    try
        //    {
        //        Console.SetIn(input);
        //        Console.SetOut(output);

        //        // Act
        //        MenuHandler.MenuMain();

        //        // Hämtar allt som skrivits till console
        //        string result = output.ToString();

        //        // Assert
        //        Assert.Contains("1. Lägg till fordon\r\n", result);
        //        Assert.Contains("2. Ta bort fordon\r\n", result);
        //        Assert.Contains("3. Visa fordon\r\n", result);
        //        Assert.Contains("4. Hämta fordon från fil\r\n", result);
        //        Assert.Contains("0. Avsluta\r\n", result);
        //    }
        //    finally
        //    {
        //        Console.SetIn(originalIn);
        //        Console.SetOut(originalOut);
        //    }
        //}

        //[Fact]
        //static public void TestMenuRemoveVehicle()
        //{
        //    // Arrange
        //    var originalIn = Console.In;
        //    var originalOut = Console.Out;

        //    using var input = new StringReader("0\n");
        //    using var output = new StringWriter();

        //    try
        //    {
        //        Console.SetIn(input);
        //        Console.SetOut(output);

        //        // Act
        //        MenuHandler.MenuMain();

        //        // Hämtar allt som skrivits till console
        //        string result = output.ToString();

        //        // Assert
        //        Assert.Contains("1. Lägg till fordon\r\n", result);
        //        Assert.Contains("2. Ta bort fordon\r\n", result);
        //        Assert.Contains("3. Visa fordon\r\n", result);
        //        Assert.Contains("4. Hämta fordon från fil\r\n", result);
        //        Assert.Contains("0. Avsluta\r\n", result);
        //    }
        //    finally
        //    {
        //        Console.SetIn(originalIn);
        //        Console.SetOut(originalOut);
        //    }
        //}

        //[Fact]
        //static public void TestMenuShowVehicle()
        //{
        //    // Arrange
        //    var originalIn = Console.In;
        //    var originalOut = Console.Out;

        //    using var input = new StringReader("0\n");
        //    using var output = new StringWriter();

        //    try
        //    {
        //        Console.SetIn(input);
        //        Console.SetOut(output);

        //        // Act
        //        MenuHandler.MenuMain();

        //        // Hämtar allt som skrivits till console
        //        string result = output.ToString();

        //        // Assert
        //        Assert.Contains("1. Lägg till fordon\r\n", result);
        //        Assert.Contains("2. Ta bort fordon\r\n", result);
        //        Assert.Contains("3. Visa fordon\r\n", result);
        //        Assert.Contains("4. Hämta fordon från fil\r\n", result);
        //        Assert.Contains("0. Avsluta\r\n", result);
        //    }
        //    finally
        //    {
        //        Console.SetIn(originalIn);
        //        Console.SetOut(originalOut);
        //    }
        //}

        //[Fact]
        //static public void TestLoadVehicleFromFile()
        //{
        //    // Arrange
        //    var originalIn = Console.In;
        //    var originalOut = Console.Out;

        //    using var input = new StringReader("0\n");
        //    using var output = new StringWriter();

        //    try
        //    {
        //        Console.SetIn(input);
        //        Console.SetOut(output);

        //        // Act
        //        MenuHandler.MenuMain();

        //        // Hämtar allt som skrivits till console
        //        string result = output.ToString();

        //        // Assert
        //        Assert.Contains("1. Lägg till fordon\r\n", result);
        //        Assert.Contains("2. Ta bort fordon\r\n", result);
        //        Assert.Contains("3. Visa fordon\r\n", result);
        //        Assert.Contains("4. Hämta fordon från fil\r\n", result);
        //        Assert.Contains("0. Avsluta\r\n", result);
        //    }
        //    finally
        //    {
        //        Console.SetIn(originalIn);
        //        Console.SetOut(originalOut);
        //    }
        //}

        //[Fact]
        //static public void TestExitGarage()
        //{
        //    // Arrange
        //    var originalIn = Console.In;
        //    var originalOut = Console.Out;

        //    using var input = new StringReader("0\n");
        //    using var output = new StringWriter();

        //    try
        //    {
        //        Console.SetIn(input);
        //        Console.SetOut(output);

        //        // Act
        //        MenuHandler.MenuMain();

        //        // Hämtar allt som skrivits till console
        //        string result = output.ToString();

        //        // Assert
        //        Assert.Contains("1. Lägg till fordon\r\n", result);
        //        Assert.Contains("2. Ta bort fordon\r\n", result);
        //        Assert.Contains("3. Visa fordon\r\n", result);
        //        Assert.Contains("4. Hämta fordon från fil\r\n", result);
        //        Assert.Contains("0. Avsluta\r\n", result);
        //    }
        //    finally
        //    {
        //        Console.SetIn(originalIn);
        //        Console.SetOut(originalOut);
        //    }
        //}
    }
}