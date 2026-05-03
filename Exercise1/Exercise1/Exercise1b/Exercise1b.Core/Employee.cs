using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1b.Core
{
    /// <summary>
    /// Klassen Employee representerar en anställd med ett namn, födelseår och timlön.
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// Klassen Employee representerar en anställd med ett namn, födelseår och timlön.
        /// Den har en konstruktor som tar emot namn, födelseår och timlön som parametrar och tilldelar dem till motsvarande egenskaper.
        /// Födelseåret parsas från en sträng till ett heltal, och om det uppstår ett fel under parsningen,
        /// fångas undantaget och ett felmeddelande skrivs ut till konsolen.
        /// </summary>
        public int Born { get; set; }
        public string Name { get; set; }
        public double HourlyRate { get; set; }
        /// <summary>
        /// Parameterlös konstruktor som krävs för att kunna skapa en instans av Employee utan att behöva ange några värden.
        /// </summary>
        public Employee() { }
        /// <summary>
        /// Konstruktorn tar emot namn, födelseår och timlön som parametrar och tilldelar dem till motsvarande egenskaper.
        /// </summary>
        /// <param name="name">Namnet på den anställde.</param>
        /// <param name="born">Födelseåret på den anställde.</param>
        /// <param name="hourlyRate">Timlönen på den anställde.</param>
        public Employee(string name, string born, string hourlyRate)
        {
            try
            {
                Born = int.Parse(born);
                Name = name;
                HourlyRate = double.Parse(hourlyRate);
            }
            catch (Exception)
            {
                Console.WriteLine("Somthing went wrong, try again!\n");
            }
        }
    }
}
