using System.Collections.ObjectModel;

namespace Exercise1b.Core.xUnitTest
{
    public class xUnitTest
    {
        [Fact]
        public void TestEmployeeName()
        {
            // Arrange
            var employee = new Employee("Sture Svensson", "1980", "215");
            // Act
            var employee2 = new Employee();
            employee2.Name = "Sture Svensson";
            employee.Born = 1985;
            employee.HourlyRate = double.TryParse("215.0", out double hourlyRate) ? hourlyRate : 0;
            //employee.HourlyRate = 215.0;
            // Assert
            Assert.Equal(employee.Name, employee2.Name);
            Assert.NotEqual(employee.Born, employee2.Born);
            Assert.Equal(employee.HourlyRate, employee2.HourlyRate);
        }

        [Fact]
        public void TestAddPerson()
        {
            //Arrange
            var employees = new ObservableCollection<Employee>();
            employees.Add(new Employee("John Doe", "1980", "15.5"));
            //Act
            var employee2 = new Employee("Jane Doe", "1990", "20.0");
            employees.Add(employee2);

            //Assert
            Assert.Contains(employee2, employees);
            Assert.Equal(2, employees.Count);
            Assert.Equal("Jane Doe", employees[1].Name);
            Assert.Equal(1990, employees[1].Born);
            Assert.Equal(double.TryParse("20.0", out double hourlyRate) ? hourlyRate : 0, employees[1].HourlyRate);
        }

        [Fact]
        public void TestRemovePerson()
        {
            //Arrange
            var employees = new ObservableCollection<Employee>();
            var employee1 = new Employee("John Doe", "1980", "15.5");
            var employee2 = new Employee("Jane Doe", "1990", "20.0");
            employees.Add(employee1);
            employees.Add(employee2);
            //Act
            employees.Remove(employee1);
            //Assert
            Assert.DoesNotContain(employee1, employees);
            Assert.Contains(employee2, employees);
            Assert.Single(employees);
        }
    }
}