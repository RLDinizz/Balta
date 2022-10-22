using System;

namespace StopWatch
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
            Console.WriteLine("S = Segundo => 10s = 10 segundos");
            Console.WriteLine("M = Minuto => 10m = minutos");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo deseja conta?");
            string data = Console.ReadLine().ToLower();

            if (data == "0")
            {
                System.Environment.Exit(0);
            }

            var time = int.Parse(data.Substring(0, data.Length - 1));
            var type = char.Parse(data.Substring(data.Length - 1, 1));

            switch (type)
            {
                case 's': StartSegundos(time); break;
                case 'm': StartMinutos(time); break;
                default:
                    {
                        Console.WriteLine("Opção de tempo inválida!");
                        Thread.Sleep(1000);
                        Menu();
                        break;
                    }
            }
        }

        static void StartSegundos(int time)
        {
            var currentTime = 0;

            while (currentTime <= time)
            {
                Console.Clear();
                Console.WriteLine($"{currentTime} segundos");
                Thread.Sleep(1000);
                currentTime++;
            }
            Console.WriteLine("Contador finalizado!");
            Thread.Sleep(2500);
            Menu();
        }
        static void StartMinutos(int time)
        {
            var currentTime = 0;

            while (currentTime < time)
            {
                Console.Clear();
                var segundos = 0;
                while (segundos < 60)
                {
                    Console.Clear();
                    Console.WriteLine($"{currentTime} minutos e {segundos} segundos");
                    Thread.Sleep(100);
                    segundos++;
                }
                currentTime++;
            }
            Console.Clear();
            Console.WriteLine($"{currentTime} minutos e 0 segundos");
            Console.WriteLine("Contador finalizado!");
            Thread.Sleep(2500);
            Menu();
        }
    }
}