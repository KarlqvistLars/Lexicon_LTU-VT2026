namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = 0;
            while (lines == 0)
            {   
                Console.Write("Ange antal personer att lägga till: ");
                lines = int.TryParse(Console.ReadLine(), out int result) ? result : 0;
                lines = lines <= 0 ? 0 : lines ;
            }
            var persons = new List<Person>();
            for (int i = 0; i < lines; i++)
            {
                var cmdArgs = Console.ReadLine().Split();
                if (cmdArgs.Length == 3)
                {
                    var person = new Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]));
                    if (!person.ErrFlag)
                    {   
                        persons.Add(person);
                    }
                    else
                    {
                        i--;                    
                    }
                }
                else if (cmdArgs.Length == 4)
                {
                    var person = new Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]), decimal.Parse(cmdArgs[3]));
                    if (!person.ErrFlag)
                    {
                        persons.Add(person);
                    }
                    else
                    {
                        i--;
                    }
                }
                else
                {
                    Console.WriteLine("Felaktigt antal argument. Förväntat 3 eller 4 argument.");
                    i--;
                }
            }
            var bonus = decimal.Parse(Console.ReadLine());
            persons.ForEach(p => p.IncreaseSalary(bonus));
            persons.ForEach(p => Console.WriteLine(p.ToString()));
        }
    }
}


