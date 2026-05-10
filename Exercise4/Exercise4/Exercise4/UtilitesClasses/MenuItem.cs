namespace Exercise4.UtilitesClasses
{
    public class MenuItem
    {
        public string Key { get; }
        public string Text { get; }
        public Action Action { get; }
        public MenuItem(string key, string text, Action action)
        {
            Key = key;
            Text = text;
            Action = action;
        }
    }

    public class Menu
    {
        public string Title { get; }
        public MenuItem[] Items { get; }
        public Menu(string title, MenuItem[] items)
        {
            Title = title;
            Items = items;
        }

        public bool running = true;
        internal bool Show()
        {
            int menuHight = 8;
            while (running)
            {
                Utilities.ShowHeader(Title);
                foreach (var item in Items)
                {
                    Console.WriteLine($"{item.Key}. {item.Text}");
                    menuHight--;
                }
                while (menuHight > 0)
                {
                    Console.WriteLine();
                    menuHight--;
                }
                //Console.WriteLine("items " + Items.Length);
                //Console.Write($"{Utilities.vTab}Välj: ");
                menuHight = 8;
                string input = ReadRequiredLine($"{Utilities.vTab}Välj: ");

                MenuItem selected = Items.First(i => i.Key.Equals(input));


                if (selected != null)
                {
                    if (selected.Key == "0") { running = false; }
                    selected.Action.Invoke();
                }
                else
                {
                    Console.WriteLine($"{Utilities.vTab}Felaktigt val.");
                    Console.ReadKey();
                }
            }
            return false;
        }

        static string ReadRequiredLine(string message)
        {
            string? input;

            do
            {
                Console.Write(message);
                input = Console.ReadLine();

                if (input == null)
                {
                    Console.WriteLine("Ingen input kunde läsas.");
                    return "";
                }

                input = input.Trim();

            } while (input == "");

            return input;
        }
    }
}
