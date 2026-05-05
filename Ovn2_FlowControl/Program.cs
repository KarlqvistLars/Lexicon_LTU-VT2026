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
                Console.WriteLine(Menu.Rubrik);
                Console.WriteLine(Menu.Rad1);
                Console.WriteLine(Menu.Rad2);
                Console.WriteLine(Menu.Rad3);
                Console.WriteLine(Menu.Rad4);
                Console.WriteLine(Menu.Rad5);
                Console.WriteLine(Menu.Rad6);
                Console.Write(Menu.MenuVal);

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

