using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public class Employee
    {
        /// <summary>
        /// Klassen Employee representerar en anställd med namn, födelseår och timlön. 
        /// Den har en konstruktor som tar emot namn, födelseår och timlön som parametrar och tilldelar dem till motsvarande egenskaper. 
        /// Födelseåret parsas från en sträng till ett heltal, och om det uppstår ett fel under parsningen, 
        /// fångas undantaget och ett felmeddelande skrivs ut till konsolen.
        /// </summary>
        public int Born { get; set; }
        public string? Name { get; set; }
        public string? HourlyRate { get; set; }
        /// <summary>
        /// Emloyee-konstruktorn tar tre strängparametrar: name, born och hourlyRate.
        /// </summary>
        /// <param name="name"></param>Name är namnet på den anställde.
        /// <param name="born"></param>Födelseåret för den anställde, som kommer att parsas till ett heltal.
        /// <param name="hourlyRate"></param>Timlönen för den anställde.
        public Employee(string name, string born, string hourlyRate)
        {
            try
            {
                Born = int.Parse(born);
                Name = name;
                HourlyRate = hourlyRate;
            }
            catch (Exception)
            {
                Console.WriteLine("Somthing went wrong, try again!\n");
            }
        }
    }
}
