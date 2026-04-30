using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Threading;
using static Exercise2.Program;

namespace Exercise2
{
    internal class Program
    {
        const int COUNT_TO_TEN = 10;
        enum TicketType
        {
            Adult,
            Youth,
            Senior
        }
        protected struct Tickets
        {
            public int Adult { get; set; }
            public int Youth { get; set; }
            public int Senior { get; set; }
        }
        protected static Tickets tickets = new Tickets();
        static void Main(string[] args)
        {
            PrintProgramChoiceMenu();
            do
            {
                var input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        PrintBioMenu();
                        break;
                    case "2":
                        PrintLoopTenMenu();
                        break;
                    case "3":
                        PrintThirdWordMenu();
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
        internal static void PrintProgramChoiceMenu()
        {
            Console.Clear();
            Console.WriteLine("\u001b[4mVälkommen till programvalmenyn!\u001b[0m");
            Console.WriteLine("Detta är huvudmenyn för programmet.\nNi navigerar menyvalen genom att använda siffran och Enter för önskat val.\n");
            Console.WriteLine("1. Köp biobiljett till Vuxen, Ungdom eller Pensionär.\n2. Upprepa 10ggr.\n3. Det 3:e ordet.\n0. Avsluta\n");
            Console.Write("Ange menyval: ");
        }
        /// <summary>
        /// Menyer för biobiljetter
        /// </summary>
        /// <returns></returns>
        internal static void PrintBioMenu()
        {
            Console.Clear();
            Console.WriteLine("\u001b[4mVälkommen på Bio!\u001b[0m");
            Console.WriteLine("Detta är huvudmenyn för biljettkassan.\nNi navigerar menyvalen genom att använda siffran och Enter för önskat val.\n");
            Console.WriteLine("1. Köp enkelbiljett.\n2. Köp biljett till sällskap.\n0. Tillbaka\n");
            Console.Write("Ange menyval: ");

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
                    PrintProgramChoiceMenu();
                    return;
                default:
                    Console.WriteLine("Invalid input. Please try again.");
                    break;
            }

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
        /// <summary>
        /// Funktioner för Biobiljetter
        /// </summary>
        /// <param name="input"></param>
        /// <param name="type"></param>
        internal static void ExecuteTicketTransaction(string? input, int type)
        {
            switch (type)
            {
                case 0:
                    if(BuyTicket(input).Youth > 0)
                    {
                        Console.WriteLine("Ungdomsbiljett köpt för 80kr.");
                    }
                    else if(BuyTicket(input).Adult > 0)
                    {
                        Console.WriteLine("Vuxenbiljett köpt för 120kr.");
                    }
                    else if(BuyTicket(input).Senior > 0)
                    {
                        Console.WriteLine("Pensionärsbiljett köpt för 90kr.");
                    }
                    break;
                case 1:
                    PresentTotal(BuyCompanyTicket(input));
                    break;
                default:
                    break;
            }
            Console.WriteLine("\nTryck på Enter för att återgå till menyn.");
            Console.ReadLine();
            PrintBioMenu();
        }
        private static void PresentTotal(Tickets tickets)
        {
            if (tickets.Adult>0)
            {
                Console.WriteLine("{0}st Vuxenbiljetter köpta för {1}kr á 120kr.", tickets.Adult, tickets.Adult * 120);
            }
            if (tickets.Youth > 0)
            {
                Console.WriteLine("{0}st Ungdomsbiljetter köpta för {1}kr á 80kr.", tickets.Youth, tickets.Youth * 80);
            }
            if (tickets.Senior > 0)
            {
                Console.WriteLine("{0}st Pensionärsbiljetter köpta för {1}kr á 90kr.", tickets.Senior, tickets.Senior * 90);
            }
            Console.WriteLine("Total summa: {0}kr", tickets.Adult * 120 + tickets.Youth * 80 + tickets.Senior * 90);
        }
        private static TicketType ChooseTicketType(int age)
        {
            if (age < 20)
            {
                return TicketType.Youth;
            }
            else if (age > 64)
            {
                return TicketType.Senior;
            }
            else
            {
                return TicketType.Adult;
            }
        }
        protected static Tickets BuyTicket(string? input)
        {
            Tickets ticket = new Tickets();
            if (int.TryParse(input, out int age))
            {
                switch (ChooseTicketType(age))
                {
                    case TicketType.Adult:
                        ticket.Adult++;
                        break;
                    case TicketType.Youth:
                        ticket.Youth++;
                        break;
                    case TicketType.Senior:     
                        ticket.Senior++;
                        break;
                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine("Ogiltig ålder. Försök igen.");
            }
            return ticket;
        }
        private static Tickets BuyCompanyTicket(string? input)
        {
            int antal = int.TryParse(input, out int result) ? result : 0;
            Tickets companyTickets = new Tickets();

            for (int i = 0; i < antal; i++)
            {
                Console.Write("Ange ålder för biljett " + (i + 1) + ": ");
                string? ageInput = Console.ReadLine();
                if (ageInput != null)
                {
                    switch (ChooseTicketType(int.Parse(ageInput)))
                    {
                        case TicketType.Adult:
                            companyTickets.Adult++;
                            break;
                        case TicketType.Youth:
                            companyTickets.Youth++;
                            break;
                        case TicketType.Senior:
                            companyTickets.Senior++;
                            break;
                    }
                }
            }
            Console.WriteLine("\n\nSammanställning:\n");
            return companyTickets;
        }
        private static void PrintLoopTenMenu()
        {
            Console.Clear();
            Console.Write("\n\nAnge en mening: ");
            string? sentence = Console.ReadLine();
            for (int i = 0; i < COUNT_TO_TEN; i++)
            {
                Console.WriteLine(sentence);
            }
            Console.WriteLine();
            Console.WriteLine("\nTryck på Enter för att återgå till menyn.");
            Console.ReadLine();
            PrintProgramChoiceMenu();
        }
        private static void PrintThirdWordMenu()
        {
            throw new NotImplementedException();
        }
    }
 }
