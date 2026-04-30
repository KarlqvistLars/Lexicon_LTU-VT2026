using System;

namespace Exercise2
{
    public class Program
    {
        const int COUNT_TO_TEN = 10;
        public enum TicketType
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
                        Console.WriteLine("Felaktigt menyval. Försök igen.");
                        break;
                }
            } while (true);
        }
        internal static void PrintProgramChoiceMenu()
        {
            Console.Clear();
            Console.WriteLine("\u001b[4mVälkommen till programvalmenyn!\u001b[0m");
            Console.WriteLine("Detta är huvudmenyn för programmet.\nNi navigerar menyvalen genom att använda siffran och Enter för önskat val.\n");
            Console.WriteLine("1. Köp biobiljett.\n2. Upprepa 10ggr.\n3. Det 3:e ordet.\n0. Avsluta\n");
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
                    Console.WriteLine("Felaktigt menyval. Försök igen.");
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
            Console.WriteLine("Pensionär(över 64år):\t90kr\n");
            Console.Write("Ange er ålder: ");
            int age = int.TryParse(Console.ReadLine(), out int result) ? result : -1;
            ExecuteTicketTransaction(age, 0);
        }
        internal static void PrintMenuSamlingsbiljett()
        {
            Console.Clear();
            Console.WriteLine("\u001b[4mVälkommen på Bio!\u001b[0m");
            Console.WriteLine("\nSamlingsbiljett");
            Console.WriteLine("\u001b[4mBiljettpriser\u001b[0m");
            Console.WriteLine("Vuxen: \t\t\t120kr");
            Console.WriteLine("Ungdom(under 20 år):\t80kr");
            Console.WriteLine("Pensionär(över 64år):\t90kr\n");
            Console.Write("Ange antal: ");
            int age = int.TryParse(Console.ReadLine(), out int result) ? result : -1;
            ExecuteTicketTransaction(age, 1);
        }
        /// <summary>
        /// Funktioner för Biobiljetter
        /// </summary>
        /// <param name="input"></param>
        /// <param name="type"></param>
        internal static void ExecuteTicketTransaction(int age, int type)
        {
            //int age = int.TryParse(input, out int result) ? result : -1;
            switch (type)
            {
                case 0:
                    if(age >= 0)
                    {
                        if (BuyTicket(age).Youth > 0)
                        {
                            Console.WriteLine("Ungdomsbiljett köpt för 80kr.");
                        }
                        else if (BuyTicket(age).Adult > 0)
                        {
                            Console.WriteLine("Vuxenbiljett köpt för 120kr.");
                        }
                        else if (BuyTicket(age).Senior > 0)
                        {
                            Console.WriteLine("Pensionärsbiljett köpt för 90kr.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Felaktigt angiven ålder. Ingen biljett köpt.");
                    }
                    break;
                case 1:
                    PresentTotal(BuyCompanyTicket(age));
                    break;
                default:
                    break;
            }
            Console.WriteLine("\nTryck på Enter för att återgå till menyn...");
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
        public static TicketType ChooseTicketType(int age)
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
        protected static Tickets BuyTicket(int age)
        {
            Tickets ticket = new Tickets();
            if (age!=0)
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
        private static Tickets BuyCompanyTicket(int antal)
        {
            Tickets companyTickets = new Tickets();

            for (int i = 0; i < antal; i++)
            {
                Console.Write("Ange ålder för biljett " + (i + 1) + ": ");
                string? ageInput = Console.ReadLine();
                int age = int.TryParse(ageInput, out int parsedAge) ? parsedAge : -1;
                if (ageInput != null && age > 0)
                {
                    switch (ChooseTicketType(age))
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
        /// <summary>
        /// Meny och funktion för att skriva ut en mening 10 gånger, där meningen matas in av användaren.
        /// </summary>
        private static void PrintLoopTenMenu()
        {
            Console.Clear();
            Console.Write("\u001b[4mVälkommen till PRINT-TEN!\u001b[0m");
            Console.Write("\nSkriv en \"oneliner\" mening: ");
            string? sentence = Console.ReadLine();
            for (int i = 0; i < COUNT_TO_TEN; i++)
            {
                Console.WriteLine(sentence);
            }
            Console.WriteLine();
            Console.WriteLine("\nTryck på Enter för att återgå till menyn...");
            Console.ReadLine();
            PrintProgramChoiceMenu();
        }
        /// <summary>
        /// Meny och funktion för att skriva ut det 3:e ordet i en mening, om det finns 3 eller fler ord i meningen.
        /// </summary>
        private static void PrintThirdWordMenu()
        {
            Console.Clear();
            Console.Write("\u001b[4mVälkommen till Det 3:e Ordet!\u001b[0m");
            Console.Write("\nSkriv en mening innehållande mer än 3st ord: ");
            string? sentence = Console.ReadLine();
            string[] words = sentence?.Split(' ') ?? Array.Empty<string>();
            Console.WriteLine();
            if (words.Length >= 3)
            {
                Console.WriteLine("Det 3:e ordet är: " + words[2]);
            }
            else
            {
                Console.WriteLine("Mening innehåller inte tillräckligt med ord.");
            }
            Console.WriteLine("\nTryck på Enter för att återgå till menyn...");
            Console.ReadLine();
            PrintProgramChoiceMenu();
        }
    }
 }
