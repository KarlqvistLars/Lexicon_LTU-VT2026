using System;

namespace Ovn2_FlowControl
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("Välkommen till huvudmenyn.");
                Console.WriteLine("Skriv en siffra för att välja funktion.");
                Console.WriteLine("0 = Avsluta");
                Console.WriteLine("1 = Ungdom eller pensionär");
                Console.WriteLine("2 = Pris för sällskap");
                Console.WriteLine("3 = Upprepa tio gånger");
                Console.WriteLine("4 = Det tredje ordet");
                Console.Write("Ditt val: ");

                string? input = Console.ReadLine();

                switch (input)
                {
                    case "0":
                        running = false;
                        Console.WriteLine("Programmet avslutas.");
                        break;

                    case "1":
                        Bio.UngdomEllerPensionar();
                        break;

                    case "2":
                        Bio.PrisForSallskap();
                        break;

                    case "3":
                        Ord.UpprepaTioGanger();
                        break;

                    case "4":
                        Ord.DetTredjeOrdet();
                        break;

                    default:
                        Console.WriteLine("Felaktig input, välj 0-4.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}

