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
        public bool Show()
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
                Console.Write($"{Utilities.vTab}Välj: ");
                menuHight = 8;
                string? input = Console.ReadLine();
                MenuItem? selected = Items.FirstOrDefault(i => i.Key == input);
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
        public static class ConsoleHelper
        {
            public static void WriteAt(int left, int top, string text)
            {
                Console.SetCursorPosition(left, top);
                Console.Write(text);
            }
        }

    }
}
