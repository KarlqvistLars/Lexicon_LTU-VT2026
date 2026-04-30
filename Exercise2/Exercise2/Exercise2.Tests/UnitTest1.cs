namespace Exercise2
{
    public class UnitTest1
    {
        [Fact]
        public void TestChooseTicketType()
        {
            // Arrange
            int p1 = 4; // Free ticket
            int p2 = 15;  // Youth ticket
            int p3 = 25;  // Adult ticket
            int p4 = 55;  // Adult ticket
            int p5 = 65;  // Senior ticket
            int p6 = 99;  // Senior ticket
            int p7 = 101; // Feed ticket

            // Act
            var ticket1 = Program.ChooseTicketType(p1);
            var ticket2 = Program.ChooseTicketType(p2);
            var ticket3 = Program.ChooseTicketType(p3);
            var ticket4 = Program.ChooseTicketType(p4);
            var ticket5 = Program.ChooseTicketType(p5);
            var ticket6 = Program.ChooseTicketType(p6);
            var ticket7 = Program.ChooseTicketType(p7);

            // Assert
            Assert.Equal(Exercise2.Program.TicketType. , ticket1);
            Assert.Equal(Exercise2.Program.TicketType.Adult, ticket2);
            Assert.Equal(Exercise2.Program.TicketType.Adult, ticket3);
            Assert.Equal(Exercise2.Program.TicketType.Adult, ticket4);
            Assert.Equal(Exercise2.Program.TicketType.Adult, ticket5);
            Assert.Equal(Exercise2.Program.TicketType.Adult, ticket6);
            Assert.Equal(Exercise2.Program.TicketType.Adult, ticket7);
        }
    }
}