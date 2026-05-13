using static Exercise3.UtilitesClasses.Utilities;
namespace Exercise3.Tests


{
    public class UnitTestUtilities
    {
        [Fact]
        static public void TestReadRegnumInput()
        {
            // Arrange
            Garage G = new Garage(2); // Sätter kapaciteten till 2 för att testa att inte kunna lägga till fler än en bil
            String REGNUM0 = "ABD 232"; //Korrekt format
            String REGNUM1 = "ABC 132"; //Korrekt format
            String REGNUM2 = "ABC132"; // Saknar mellanslag
            String REGNUM3 = "132 ABC"; // Fel ordning
            String REGNUM4 = "FL52036"; // Fel ordning och saknar mellanslag
            String REGNUM5 = "Bo566"; // Felaktigt format, saknar mellanslag och har för få tecken
            String REGNUM6 = "BR 12345"; // Mellanslag felaktigt
            String REGNUM7 = "SE-UGV"; // Korrekt format
            String REGNUM8 = "SEADC"; // Saknar binde sträck och mellanslag
            String REGNUM9 = "N50123"; // Amerikanskt format
            Vehicle[] vehicles = {
                new Car(REGNUM1, "Röd", 1200, 4, 4, 4),
                new Motorcycle(REGNUM0, "Blå", 200, 2, 2, 2),
            };

            // Act
            bool isAddedOk1 = G.AddVehicle(new Car("ABC 132", "Röd", 1200, 4, 4, 4));
            bool isAddedOk2 = G.AddVehicle(new Motorcycle("ABD 232", "Blå", 200, 2, 2, 2));
            Vehicle[] v = G.Vehicles;
            //bool isAddedOk3 = G.AddVehicle(new Car("ABC 134", "Röd", 1200, 4, 4, 4));
            bool isAddedOk4 = G.RemoveVehicle("ABC133");
            bool isAddedOk5 = G.RemoveVehicle("ABC 133");
            bool isAddedOk6 = G.AddVehicle(new Car("ABC 135", "Röd", 1200, 4, 4, 4));
            bool isAddedOk7 = G.AddVehicle(new Car("ABC 136", "Röd", 1200, 4, 4, 4));
            int capacity = G.Capacity;
            string[] result1 = ReadRegnumInput(VType.Car, REGNUM1);
            string[] result2 = ReadRegnumInput(VType.Motorcycle, REGNUM2);
            string[] result3 = ReadRegnumInput(VType.Bus, REGNUM3);
            string[] result4 = ReadRegnumInput(VType.Car, REGNUM4);
            string[] result5 = ReadRegnumInput(VType.Boat, REGNUM5);
            string[] result6 = ReadRegnumInput(VType.Boat, REGNUM6);
            string[] result7 = ReadRegnumInput(VType.Airplane, REGNUM7);
            string[] result8 = ReadRegnumInput(VType.Airplane, REGNUM8);
            string[] result9 = ReadRegnumInput(VType.Airplane, REGNUM9);
            string tostring = G.ToString();

            // Assert
            Assert.True(isAddedOk1);
            Assert.True(isAddedOk2);
            Assert.Equal(vehicles.ToString(), v.ToString());
            Assert.Equal(vehicles.ToString(), v.ToString());
            //Assert.False(isAddedOk3);
            Assert.False(isAddedOk4);
            Assert.False(isAddedOk5);
            Assert.False(isAddedOk6);
            Assert.False(isAddedOk7);
            Assert.Equal(2, v.Length);
            Assert.Equal(2, capacity);
            Assert.Equal("true", result1[0]);
            Assert.Equal("false", result2[0]);
            Assert.Equal("false", result3[0]);
            Assert.Equal("false", result4[0]);
            Assert.Equal("false", result5[0]);
            Assert.Equal("false", result6[0]);
            Assert.Equal("true", result7[0]);
            Assert.Equal("false", result8[0]);
            Assert.Equal("false", result9[0]);
            Assert.Equal(tostring, G.ToString());
        }
    }
}