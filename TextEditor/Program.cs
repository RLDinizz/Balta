namespace TextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("O que você deseja fazer?");
            Console.WriteLine("1 - Abrir arquivo");
            Console.WriteLine("2 - Criar novo arquivo");
            Console.WriteLine("0 - Sair");
            var option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 0: System.Environment.Exit(0); break;
                case 1: Abrir(); break;
                case 2: Editar(); break;
                default: Menu(); break;
            }
        }
        static void Abrir()
        {
            Console.Clear();
            Console.WriteLine("Qual o caminho do arquivo?");

            var path = Console.ReadLine();

            using (var file = new StreamReader(path))
            {
                Console.WriteLine(file.ReadToEnd());
            }

            Console.WriteLine("");
            Console.ReadLine();

            Menu();
        }
        static void Salvar(string text)
        {
            Console.Clear();
            Console.WriteLine("Onde deseja salvar?");
            var path = Console.ReadLine();

            using (var file = new StreamWriter(path))
            {
                file.Write(text);

            }

            Console.WriteLine($"Arquivo {path} salvo com sucesso!");
            Thread.Sleep(2500);
            Menu();
        }
        static void Editar()
        {
            Console.Clear();
            Console.WriteLine("Digite seu texot abaixo. (ESC para sair)");
            Console.WriteLine("------------------------");

            string text = "";
            do
            {
                text += Console.ReadLine() + Environment.NewLine;
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            Salvar(text);
            Menu();
        }
    }
}