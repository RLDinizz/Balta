namespace EditorHtml
{
    public static class Menu
    {
        const int lagura = 100;
        const int altura = 10;
        public static void Show()
        {
            DrawScreen();
            WriteOption();

            var option = short.Parse(Console.ReadLine());
            HandleMenuOption(option);
        }
        public static void DrawScreen()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            LinhaTraco();
            LinhaEspaco();
            LinhaTraco();
        }
        public static void WriteOption()
        {
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("===========");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Selecione uma opção abaixo:");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("1- Novo Arquivo");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("2- Abrir");
            Console.SetCursorPosition(3, 8);
            Console.WriteLine("0- Sair");
            Console.SetCursorPosition(3, 10);
            Console.Write("opção: ");
        }
        public static void HandleMenuOption(short option)
        {
            switch (option)
            {
                case 1: Editor.Show(); break;
                case 2: Console.WriteLine("View"); break;
                case 0:
                    {
                        Console.Clear();
                        System.Environment.Exit(0);
                        break;
                    }
                default: Show(); break;
            }
        }
        private static void LinhaTraco()
        {
            Console.Write("+");
            for (int i = 0; i <= lagura; i++)
            {
                Console.Write("-");
            }
            Console.Write("+");
            Console.Write("\n");
        }
        private static void LinhaEspaco()
        {
            for (int i = 0; i <= altura; i++)
            {
                Console.Write("|");
                for (int x = 0; x <= lagura; x++)
                    Console.Write(" ");
                Console.Write("|");
                Console.Write("\n");
            }
        }
    }
}