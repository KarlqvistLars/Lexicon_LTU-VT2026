namespace Exercise2
{
    public class UnitTest1
    {
        [Fact]
        public void TestChooseTicketTypeFree()
        {
            // Arrange - Free ticket limit for children under 5 years old and free ticket for ages 100 and above
            int p1 = 4; // Free ticket
            int p2 = 5; // Youth ticket
            int p3 = 0; // Free ticket
            int p4 = 101; // Free ticket
            int p5 = 100; // Senior ticket

            // Act
            var ticket1 = Program.ChooseTicketType(p1);
            var ticket2 = Program.ChooseTicketType(p2);
            var ticket3 = Program.ChooseTicketType(p3);
            var ticket4 = Program.ChooseTicketType(p4);
            var ticket5 = Program.ChooseTicketType(p5);
            
            // Assert
            Assert.Equal(Exercise2.Program.TicketType.Free, ticket1);
            Assert.Equal(Exercise2.Program.TicketType.Youth, ticket2);
            Assert.Equal(Exercise2.Program.TicketType.Free, ticket3);
            Assert.Equal(Exercise2.Program.TicketType.Free, ticket4);
            Assert.Equal(Exercise2.Program.TicketType.Senior, ticket5);
        }

        [Fact]
        public void TestChooseTicketTypeYouth()
        {
            // Arrange - Youth ticket limit for ages 5-19
            int p1 = 4; // Free ticket
            int p2 = 5; // Youth ticket
            int p3 = 19; // // Youth ticket
            int p4 = 20; // Adult ticket

            // Act
            var ticket1 = Program.ChooseTicketType(p1);
            var ticket2 = Program.ChooseTicketType(p2);
            var ticket3 = Program.ChooseTicketType(p3);
            var ticket4 = Program.ChooseTicketType(p4);

            // Assert
            Assert.Equal(Exercise2.Program.TicketType.Free, ticket1);
            Assert.Equal(Exercise2.Program.TicketType.Youth, ticket2);
            Assert.Equal(Exercise2.Program.TicketType.Youth, ticket3);
            Assert.Equal(Exercise2.Program.TicketType.Adult, ticket4);

        }

        [Fact]
        public void TestChooseTicketTypeAdult()
        {
            // Arrange - Adult ticket limit for ages 20-64
            int p3 = 19;  // Youth ticket
            int p4 = 20;  // Adult ticket
            int p5 = 64;  // Adult ticket
            int p6 = 65;  // Senior ticket

            // Act
            var ticket3 = Program.ChooseTicketType(p3);
            var ticket4 = Program.ChooseTicketType(p4);
            var ticket5 = Program.ChooseTicketType(p5);
            var ticket6 = Program.ChooseTicketType(p6);

            // Assert
            Assert.Equal(Exercise2.Program.TicketType.Youth, ticket3);
            Assert.Equal(Exercise2.Program.TicketType.Adult, ticket4);
            Assert.Equal(Exercise2.Program.TicketType.Adult, ticket5);
            Assert.Equal(Exercise2.Program.TicketType.Senior, ticket6);
        }

        [Fact]
        public void TestChooseTicketTypeSenior()
        {
            // Arrange - Senior ticket limit for ages 65-99
            int p1 = 101;  // Free ticket
            int p2 = 65;  // Senior ticket
            int p3 = 99;  // Senior ticket
            int p4 = 20;  // Adult ticket

            // Act
            var ticket1 = Program.ChooseTicketType(p1);
            var ticket2 = Program.ChooseTicketType(p2);
            var ticket3 = Program.ChooseTicketType(p3);
            var ticket4 = Program.ChooseTicketType(p4);

            // Assert
            Assert.Equal(Exercise2.Program.TicketType.Free, ticket1);
            Assert.Equal(Exercise2.Program.TicketType.Senior, ticket2);
            Assert.Equal(Exercise2.Program.TicketType.Senior, ticket3);
            Assert.Equal(Exercise2.Program.TicketType.Adult, ticket4);

        }
    }
}