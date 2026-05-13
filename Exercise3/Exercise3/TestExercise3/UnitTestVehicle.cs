namespace Exercise3.Tests
{
    public class UnitTestVehicles
    {
        [Fact]
        public void TestVehicle()
        {
            // Arrange
            Garage G3 = new Garage(10); // Sätter kapaciteten till 2 för att testa att inte kunna lägga till fler än en bil
            String REGNUM0 = "ABD 232"; //Korrekt format
            String REGNUM1 = "ABC 132"; //Korrekt format
            String REGNUM2 = "ABC132"; // Saknar mellanslag
            String REGNUM3 = "132 ABC"; // Fel ordning
            String REGNUM4 = "SE-FVH"; // Fel ordning och saknar mellanslag
            String REGNUM5 = "Bo566"; // Felaktigt format, saknar mellanslag och har för få tecken
            String REGNUM6 = "BR 12345"; // Mellanslag felaktigt
            String REGNUM7 = "SE-UGV"; // Korrekt format
            String REGNUM8 = "SEADC"; // Saknar binde sträck och mellanslag
            String REGNUM9 = "N50123"; // Amerikanskt format
            Vehicle[] vehicles = {
                new Car(REGNUM0, "Röd", 1200, 4, 4, 4),
                new Bus(REGNUM1, "Grön", 12000, 11, 45, 6),
                new Motorcycle(REGNUM2, "Blå", 200, 2, 2, 2),
                new Boat(REGNUM3, "Röd", 1200, 4, 24.3m, 4.2m,2500m),
                new Airplane(REGNUM4, "Grön", 5000,6250,3500,14.5m,20),
                new Car(REGNUM5, "Röd", 1200, 4, 4, 4),
                new Bus(REGNUM6, "Grön", 5000, 6, 6, 6),
                new Motorcycle(REGNUM7, "Blå", 200, 2, 2, 2),
                new Boat(REGNUM8, "Röd", 1200, 4, 24.3m, 4.2m,2500m),
                new Airplane(REGNUM9, "Grön", 5000,6250,3500,14.5m,20),
            };

            // Act
            bool isAddedOk1 = G3.AddVehicle(vehicles[0]);
            bool isAddedOk2 = G3.AddVehicle(vehicles[1]);
            bool isAddedOk3 = G3.AddVehicle(vehicles[2]);
            bool isAddedOk4 = G3.AddVehicle(vehicles[3]);
            bool isAddedOk5 = G3.AddVehicle(vehicles[4]);
            bool isAddedOk6 = G3.AddVehicle(vehicles[5]);
            bool isAddedOk7 = G3.AddVehicle(vehicles[6]);
            bool isAddedOk8 = G3.AddVehicle(vehicles[7]);
            bool isAddedOk9 = G3.AddVehicle(vehicles[8]);
            string airplUuid = vehicles[9].Uuid;
            string airplType = vehicles[9].Type;
            int airplWeight = vehicles[9].Weight;
            string airplToStr = vehicles[9].ToString();
            string airplToStr2 = vehicles[9].ToString2();
            int airplLength = vehicles[9].Length;



            Vehicle[] v = G3.Vehicles;
            // Assert
            Assert.True(isAddedOk1);
            Assert.True(isAddedOk2);
            Assert.Equal(airplUuid, REGNUM9);
            Assert.Equal(airplType, "Airplane");
            Assert.Equal(airplWeight, 5000);
            Assert.Contains($"   Flygplan nr: N50123\n   Färg: Grön", airplToStr);
            Assert.Contains($"   \u001b[4mFlygplan nr: N50123\u001b[0m\n   Färg: Grön", airplToStr2);
            Assert.Equal(airplLength, 6250);
            Assert.Equal(vehicles[0].ToString(), v[0].ToString());
            Assert.Equal(vehicles[1].ToString(), v[1].ToString());
            Assert.Equal(vehicles[2].ToString(), v[2].ToString());
            Assert.Equal(vehicles[3].ToString(), v[3].ToString());
            Assert.Equal(vehicles[4].ToString(), v[4].ToString());
            Assert.Equal(vehicles[5].ToString(), v[5].ToString());
            Assert.Equal(vehicles[6].ToString(), v[6].ToString());
            Assert.Equal(vehicles[7].ToString(), v[7].ToString());
            Assert.Equal(vehicles[8].ToString(), v[8].ToString());
        }
    }
}