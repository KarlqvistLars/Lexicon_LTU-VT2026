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
                if (input == "1")
                {
                    PrintMenuEnkelbiljett();

                }
                else if (input == "2")
                {
                    Console.WriteLine("Show people");
                    
                }
                else if (input == "3")
                {
                    Console.WriteLine("Save people");
                    
                }
                else if (input == "4")
                {
                    Console.WriteLine("Exit");
                    
                    break;
                }
            } while (true);

            Console.ReadLine();
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
            Console.WriteLine("1. Köp enkelbiljett.\n2. Köp biljett till sällskap.\n9. Avsluta\n");

            Console.Write("Ange menyval: ");
        }

        internal static void PrintMenuEnkelbiljett()
        {
            Console.Clear();
            Console.WriteLine("\u001b[4mVälkommen på Bio!\u001b[0m");
            Console.WriteLine("\n\n");
            Console.WriteLine("\u001b[4mBiljettpriser\u001b[0m");
            Console.WriteLine("Vuxen: \t\t\t120kr");
            Console.WriteLine("Ungdom(under 20 år):\t80kr");
            Console.WriteLine("Pensionär(över 64år):\t120kr");
            Console.Write("Ange er ålder: ");
        }


    }
 }
