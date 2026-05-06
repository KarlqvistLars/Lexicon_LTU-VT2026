namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
         if(false)
            {
                var lines = 5;
                var persons = new List<Person>();
                for (int i = 0; i < lines; i++)
                {
    #pragma warning disable CS8602 // Dereference of a possibly null reference.
                    var cmdArgs = Console.ReadLine().Split(' ');
    #pragma warning restore CS8602 // Dereference of a possibly null reference.
                    Console.WriteLine(cmdArgs[0]);
                    Person person = new Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]));
                    persons.Add(person);
                }

                persons.OrderBy(p => p.FirstName)
                    .ThenBy(p => p.Age)
                    .ToList()
                    .ForEach(p => Console.WriteLine(p.ToString()));
            //StartUp.ReadLines(persons, lines);
        }else {
                var lines = int.Parse(Console.ReadLine());
                var persons = new List<Person>();
                for (int i = 0; i < lines; i++)
                {
                    var cmdArgs = Console.ReadLine().Split();
                    var person = new Person(cmdArgs[0],
                    cmdArgs[1],
                   int.Parse(cmdArgs[2]),
                   decimal.Parse(cmdArgs[3]));
                    persons.Add(person);
                }
                var bonus = decimal.Parse(Console.ReadLine());
                persons.ForEach(p => p.IncreaseSalary(bonus));
                persons.ForEach(p => Console.WriteLine(p.ToString()));
            }

        }
    }
}


