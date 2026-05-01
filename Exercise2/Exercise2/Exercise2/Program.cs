using System;
using System.Collections.Generic;

namespace Exercise2
{
    public class Program
    {
        const int COUNT_TO_TEN = 10;
        /// <summary>
        /// Enumeration för biljetttyper, där varje typ representerar en kategori av biobiljetter baserat på ålder: Vuxen, Ungdom, Pensionär och Fribiljett.
        /// </summary>
        public enum TicketType
        {
            Adult,
            Youth,
            Senior,
            Free,
            Err
        }
        /// <summary>
        /// Enumartion för val av presentation, där varje typ representerar en kategori av biljettköp baserat på om det är en privatperson eller ett sällskap som köper biljetter.
        /// </summary>
        internal enum GroupType
        {
            Private,
            Company
        }
        /// <summary>
        /// Representerar antalet biljetter av varje typ som köpts, där varje egenskap 
        /// (Adult, Youth, Senior, Free, Err) håller reda på antalet biljetter av den specifika typen som har köpts.
        /// Adult = 20-64år
        /// Youth = 5-19år
        /// Senior = 65-100år
        /// Free = 1-4år samt äver 100år Gratis. 
        /// Err är en felindikeringsflagga som håller reda på antalet ogiltiga åldersangivelser som har gjorts under biljettköpsprocessen.
        /// </summary>
        public struct Tickets
        {
            public int Adult { get; set; }
            public int Youth { get; set; }
            public int Senior { get; set; }
            public int Free { get; set; }
            public int Err { get; set; }
        }
        public static Tickets tickets = new Tickets();
        /// <summary>
        /// Programmets startpunkt, där huvudmenyn skrivs ut och användaren kan välja mellan att köpa biobiljetter, 
        /// skriva ut en mening 10 gånger, eller skriva ut det 3:e ordet i en mening.
        /// </summary>
        /// <param name="args"></param>arguments används inte i detta program
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
        /// <summary>
        /// Skriver ut huvudmenyn för programmet, där användaren kan välja mellan att köpa biobiljetter, 
        /// skriva ut en mening 10 gånger, eller skriva ut det 3:e ordet i en mening. 
        /// Användaren navigerar menyvalen genom att använda siffran och Enter för önskat val. 
        /// Menyn fortsätter att visas tills användaren väljer att avsluta programmet genom att ange "0".
        /// </summary>
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
        /// <summary>
        /// Skriver menyn för att köpa en enkelbiljett, där användaren anger sin ålder och biljetttypen bestäms av åldern enligt de angivna reglerna.
        /// </summary>
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
            ExecuteTicketTransaction(age, GroupType.Private);
        }
        /// <summary>
        /// Skriver menyn för att köpa biljetter till ett sällskap, där användaren först anger antalet personer i sällskapet och sedan åldern för varje person.
        /// </summary>
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
            ExecuteTicketTransaction(age, GroupType.Company);
        }
        /// <summary>
        /// Funktioner för Biobiljetter
        /// </summary>
        /// <param name="input"></param>
        /// <param name="type"></param>
        internal static void ExecuteTicketTransaction(int age, GroupType type)
        {
            switch (type)
            {
                case GroupType.Private:
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
                        else if (BuyTicket(age).Free > 0)
                        {
                            Console.WriteLine("Fribiljett. Barn under 5 år samt pensionärer över 100 år.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Felaktigt angiven ålder. Ingen biljett köpt.");
                    }
                    break;
                case GroupType.Company:
                    PresentTotal(BuyCompanyTicket(age));
                    break;
                default:
                    break;
            }
            Console.WriteLine("\nTryck på Enter för att återgå till menyn...");
            Console.ReadLine();
            PrintBioMenu();
        }
        /// <summary>
        /// Totalpris och antal biljetter presenterade i en sammanställning efter köp av samlingsbiljett.
        /// </summary>
        /// <param name="tickets"></param>
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
            if (tickets.Free > 0)
            {
                Console.WriteLine("{0}st Fribiljetter. Barn under 5 år samt pensionärer över 100 år.", tickets.Free);
            }
            Console.WriteLine("Total antal personer: {0}st Total summa: {1}kr", tickets.Free+tickets.Youth+tickets.Adult+tickets.Senior, tickets.Adult * 120 + tickets.Youth * 80 + tickets.Senior * 90);
        }
        /// <summary>
        /// Metod att välja biljetttyp baserat på ålder, där åldersgränserna är: Ungdom under 20 år, Pensionär över 64 år, Fribiljett under 5 år och över 100 år, samt Vuxen i övriga fall.
        /// </summary>
        /// <param name="age">Åldern på personen som ska köpa biljett</param>
        /// <returns>Biljetttypen som motsvarar åldern</returns>
        public static TicketType ChooseTicketType(int age)
        {
            if (age < 20 && age > 4)
            {
                return TicketType.Youth;
            }
            else if (age > 64 && age <= 100)
            {
                return TicketType.Senior;
            }
            else if (age < 5 || age > 100)
            {
                return TicketType.Free;
            }

            else
            {
                return TicketType.Adult;
            }
        }
        /// <summary>
        /// Skapa en biljett baserat på ålder, där biljettypen bestäms av ChooseTicketType-metoden. 
        /// Om åldern är ogiltig (0 eller negativ) så skrivs ett felmeddelande ut och ingen biljett skapas. 
        /// Metoden returnerar en Tickets-struktur som innehåller antalet biljetter av varje typ som köpts (i det här fallet antingen 1 av en typ eller 0 av alla typer).
        /// </summary>
        /// <param name="age">Åldern på personen som ska köpa biljett</param>
        /// <returns>En Tickets-struktur som innehåller antalet biljetter av varje typ som köpts</returns>
        public static Tickets BuyTicket(int age)
        {
            Tickets ticket = new Tickets();
            if (age > 0)
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
                    case TicketType.Free:
                        ticket.Free++;
                        break;
                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine("Ogiltig ålder. Försök igen.");
                ticket.Err++;
            }
            return ticket;
        }
        /// <summary>
        /// Metod att köpa biljetter för ett sällskap, där användaren först anger antalet personer i sällskapet och sedan åldern för varje person.
        /// </summary>
        /// <param name="antal">Antalet personer i sällskapet</param>
        /// <returns>En Tickets-struktur som innehåller antalet biljetter av varje typ som köpts för sällskapet</returns>
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
                        case TicketType.Free:
                            companyTickets.Free++;
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
            var words = sentence?.Split(null as char[], StringSplitOptions.RemoveEmptyEntries) ?? Array.Empty<string>();
            Console.WriteLine(words.Length);
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
