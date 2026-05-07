namespace Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] data = new string[30];
            bool running = true;
            Console.Write("Ange antal platser i Garage: ");
            int size = int.TryParse(Console.ReadLine(), out int result) ? result : 0;
            if (size<=0)
            {
                Console.WriteLine("Ogiltigt antal platser. Programmet avslutas.");
                return;
            }
            if(MenuHandler.StartGarage(size)){ 
                return;
            }
            else
            {
                MenuHandler.ShowMenu(0);
            }
        }
    }
}
