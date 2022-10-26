using System.Text.RegularExpressions;

namespace EditorHtml
{
    public class Viwer
    {
        public static void Show(String text)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            Console.WriteLine("Modo Visualizão");
            Console.WriteLine("===============");
            Replace(text);
            Console.ReadKey();
            Menu.Show();
        }

        public static void Replace(String text)
        {
            var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
            var words = text.Split(" ");

            for (var i = 0; i < words.Length; i++)
            {
                if (strong.IsMatch(words[i]))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(words[i].Substring(words[i].IndexOf('>') + 1, (words[i].LastIndexOf('<') - 1) - words[i].IndexOf('>')));
                    Console.Write(" ");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(words[i]);
                    Console.Write(" ");
                }
            }


        }
    }
}
