namespace Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Vehicle v1 = new Vehicle(1, "Red", 4, 1000, 4);

            Console.WriteLine(v1.ToString());

        }
    }
}
