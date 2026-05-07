using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class MenuHandler
    {
        const int LENGTH = 10;
        static List<string> menu = new List<string> { "Option 1","Option 2","Option 3","","","","","","Näst sista raden.",""};
        /// <summary>
        /// Metod för att visa Huvudmenyn
        /// </summary>
        public static void ShowMenuMain()
        {
            bool counting = true;
            Console.WriteLine("=== Main Menu ===");
            for (int i = 0; i < LENGTH; i++)
            {
                if(string.IsNullOrEmpty(menu[i]) || string.IsNullOrWhiteSpace(menu[i])) 
                { 
                    Console.WriteLine($" {menu[i]} "); 
                    counting = false;
                    continue;                                                                       
                }else if (!counting)
                {
                    Console.WriteLine($" {menu[i]} ");
                    continue;
                }
                Console.WriteLine($"{i + 1}. {menu[i]} ");
            }
        }
    }
}
