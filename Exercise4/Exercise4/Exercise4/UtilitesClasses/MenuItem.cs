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
        public void Show()
        {
            int menuHight = 8;
            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(" * ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Garage 1.0");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(" * ");
                Console.ResetColor();
                Console.WriteLine("================================");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($" {Title}");
                Console.ResetColor();
                Console.WriteLine("================================");
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
                Console.Write("Välj: ");
                menuHight = 8;
                string? input = Console.ReadLine();
                MenuItem? selected = Items.FirstOrDefault(i => i.Key == input);
                if (selected != null)
                {
                    selected.Action.Invoke();
                }
                else
                {
                    Console.WriteLine("Felaktigt val.");
                    Console.ReadKey();
                }
            }
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
