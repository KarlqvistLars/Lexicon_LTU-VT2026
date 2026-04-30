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
            Console.WriteLine("Pensionär(över 64år):\t120kr");
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
            Console.WriteLine("Pensionär(över 64år):\t120kr");
            Console.Write("Ange antal: ");
            ExecuteTicketTransaction(Console.ReadLine(), 1);
        }

        internal static void ExecuteTicketTransaction(string? input, int type)
        {
            Console.WriteLine("Executing ticket transaction..."+ input + " " + type);
        }

    }
 }
