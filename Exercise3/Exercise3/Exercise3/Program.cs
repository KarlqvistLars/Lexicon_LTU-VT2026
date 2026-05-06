namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
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
        }
    }
}
