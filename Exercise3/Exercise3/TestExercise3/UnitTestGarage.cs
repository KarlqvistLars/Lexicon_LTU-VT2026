using static Exercise3.UtilitesClasses.Utilities;
namespace Exercise3.Tests


{
    public class UnitTestGarage
    {
        [Fact]
        public void TestReadRegnumInput()
        {
            // Arrange
            Garage G2 = new Garage(2); // Sätter kapaciteten till 2 för att testa att inte kunna lägga till fler än en bil
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
            bool isAddedOk1 = G2.AddVehicle(new Car("ABC 132", "Röd", 1200, 4, 4, 4));
            bool isAddedOk2 = G2.AddVehicle(new Motorcycle("ABD 232", "Blå", 200, 2, 2, 2));
            Vehicle[] v = G2.Vehicles;
            bool isAddedOk3 = G2.AddVehicle(new Car("ABC 134", "Röd", 1200, 4, 4, 4));
            bool isAddedOk4 = G2.RemoveVehicle("ABC133");
            bool isAddedOk5 = G2.RemoveVehicle("ABC 133");
            bool isAddedOk6 = G2.AddVehicle(new Car("ABC 135", "Röd", 1200, 4, 4, 4));
            bool isAddedOk7 = G2.AddVehicle(new Car("ABC 136", "Röd", 1200, 4, 4, 4));
            int capacity = G2.Capacity;
            bool result1 = ReadRegnumInput(G2, VType.Car, REGNUM1);
            bool result2 = ReadRegnumInput(G2, VType.Motorcycle, REGNUM2);
            bool result3 = ReadRegnumInput(G2, VType.Bus, REGNUM3);
            bool result4 = ReadRegnumInput(G2, VType.Car, REGNUM4);
            bool result5 = ReadRegnumInput(G2, VType.Boat, REGNUM5);
            bool result6 = ReadRegnumInput(G2, VType.Boat, REGNUM6);
            bool result7 = ReadRegnumInput(G2, VType.Airplane, REGNUM7);
            bool result8 = ReadRegnumInput(G2, VType.Airplane, REGNUM8);
            bool result9 = ReadRegnumInput(G2, VType.Airplane, REGNUM9);
            string tostring = G2.ToString();

            // Assert
            Assert.True(isAddedOk1);
            Assert.True(isAddedOk2);
            Assert.Equal(vehicles.ToString(), v.ToString());
            Assert.Equal(vehicles.ToString(), v.ToString());
            Assert.False(isAddedOk3);
            Assert.False(isAddedOk4);
            Assert.False(isAddedOk5);
            Assert.False(isAddedOk6);
            Assert.False(isAddedOk7);
            Assert.Equal(2, v.Length);
            Assert.Equal(2, capacity);
            Assert.True(result1);
            Assert.False(result2);
            Assert.False(result3);
            Assert.False(result4);
            Assert.False(result5);
            Assert.False(result6);
            Assert.True(result7);
            Assert.False(result8);
            Assert.False(result9);
            Assert.Equal(tostring, G2.ToString());
        }
    }
}