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
            while (true)
            {
                Console.Clear();
                Console.WriteLine("================================");
                Console.WriteLine($" {Title}");
                Console.WriteLine("================================");
                foreach (var item in Items)
                {
                    Console.WriteLine($"{item.Key}. {item.Text}");
                }
                Console.WriteLine();
                Console.Write("Välj: ");
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
