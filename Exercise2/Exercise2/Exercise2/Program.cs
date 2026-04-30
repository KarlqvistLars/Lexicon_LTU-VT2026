using System;
using System.Collections.Generic;
using System.IO;

namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintHeadMenu();
            do
            {
                var input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        PrintMenuEnkelbiljett();
                        break;
                    case "2":
                        PrintMenuSamlingsbiljett();
                        break;
                    case "0":
                        Console.WriteLine("Exit");
                        return;
                    default:
                        Console.WriteLine("Invalid input. Please try again.");
                        break;
                }
            } while (true);
        }
        /// <summary>
        /// Menyer för biobiljetter
        /// </summary>
        /// <returns></returns>
        internal static void PrintHeadMenu()
        {
            Console.Clear();
            Console.WriteLine("\u001b[4mVälkommen på Bio!\u001b[0m");
            Console.WriteLine("Detta är huvudmenyn för biljettkassan.\nNi navigerar menyvalen genom att använda siffran och Enter för önskat val.\n");
            Console.WriteLine("1. Köp enkelbiljett.\n2. Köp biljett till sällskap.\n0. Avsluta\n");
            Console.Write("Ange menyval: ");
        }
        internal static void PrintMenuEnkelbiljett()
        {
            Console.Clear();
            Console.WriteLine("\u001b[4mVälkommen på Bio!\u001b[0m");
            Console.WriteLine("\nEnkelbiljett");
            Console.WriteLine("\u001b[4mBiljettpriser\u001b[0m");
            Console.WriteLine("Vuxen: \t\t\t120kr");
            Console.WriteLine("Ungdom(under 20 år):\t80kr");
            Console.WriteLine("Pensionär(över 64år):\t90kr");
            Console.Write("Ange er ålder: ");
            ExecuteTicketTransaction(Console.ReadLine(), 0);
        }
        internal static void PrintMenuSamlingsbiljett()
        {
            Console.Clear();
            Console.WriteLine("\u001b[4mVälkommen på Bio!\u001b[0m");
            Console.WriteLine("\nSamlingsbiljett");
            Console.WriteLine("\u001b[4mBiljettpriser\u001b[0m");
            Console.WriteLine("Vuxen: \t\t\t120kr");
            Console.WriteLine("Ungdom(under 20 år):\t80kr");
            Console.WriteLine("Pensionär(över 64år):\t90kr");
            Console.Write("Ange antal: ");
            ExecuteTicketTransaction(Console.ReadLine(), 1);
        }
        internal static void ExecuteTicketTransaction(string? input, int type)
        {
            Console.WriteLine("Executing ticket transaction..."+ input + " " + type);
            switch (type)
            {
                case 0:
                    BuySingleTicket(input);
                    break;
                case 1:
                    BuyCompanyTicket(input);
                    break;
                default:
                    break;
            }

            Console.ReadLine();
            PrintHeadMenu();
        }
        private static void BuySingleTicket(string? input)
        {
            if (int.TryParse(input, out int age))
            {
                if (age < 20)
                {
                    Console.WriteLine("Ungdomsbiljett köpt för 80kr.");
                }
                else if (age > 64)
                {
                    Console.WriteLine("Pensionärsbiljett köpt för 90kr.");
                }
                else
                {
                    Console.WriteLine("Vuxenbiljett köpt för 120kr.");
                }
            }
            else
            {
                Console.WriteLine("Ogiltig ålder. Försök igen.");
            }
        }
        private static void BuyCompanyTicket(string? input)
        {
            throw new NotImplementedException();
        }
    }
 }
