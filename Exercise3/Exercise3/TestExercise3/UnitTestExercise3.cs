using static Exercise3.UtilitesClasses.Utilities;
namespace Exercise3.Tests


{
    public class UnitTestGarageHandler
    {
        [Fact]
        static public void TestReadRegnumInput()
        {
            // Arrange
            Garage G = new Garage(10);
            bool isAddedOk = G.AddVehicle(new Car("ABC 132", "Röd", 1200, 4, 4, 4));
            String REGNUM1 = "ABC 132"; //Korrekt format
            String REGNUM2 = "ABC132"; // Saknar mellanslag
            String REGNUM3 = "132 ABC"; // Fel ordning
            String REGNUM4 = "FL52036"; // Fel ordning och saknar mellanslag
            String REGNUM5 = "Bo566"; // Felaktigt format, saknar mellanslag och har för få tecken
            String REGNUM6 = "BR 12345"; // Mellanslag felaktigt
            String REGNUM7 = "SE-UGV"; // Korrekt format
            String REGNUM8 = "SEADC"; // Saknar binde sträck och mellanslag
            String REGNUM9 = "N50123"; // Amerikanskt format

            // Act
            bool result1 = ReadRegnumInput(G, VType.Car, REGNUM1);
            bool result2 = ReadRegnumInput(G, VType.Motorcycle, REGNUM2);
            bool result3 = ReadRegnumInput(G, VType.Bus, REGNUM3);
            bool result4 = ReadRegnumInput(G, VType.Car, REGNUM4);
            bool result5 = ReadRegnumInput(G, VType.Boat, REGNUM5);
            bool result6 = ReadRegnumInput(G, VType.Boat, REGNUM6);
            bool result7 = ReadRegnumInput(G, VType.Airplane, REGNUM7);
            bool result8 = ReadRegnumInput(G, VType.Airplane, REGNUM8);
            bool result9 = ReadRegnumInput(G, VType.Airplane, REGNUM9);

            // Assert
            Assert.True(isAddedOk);
            Assert.True(result1);
            Assert.False(result2);
            Assert.False(result3);
            Assert.False(result4);
            Assert.False(result5);
            Assert.False(result6);
            Assert.True(result7);
            Assert.False(result8);
            Assert.False(result9);
        }
    }
}