using System;

namespace Calculator
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

            Console.WriteLine("Object que deseja fazer");
            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("9 - Sair");

            Console.Write("Selecione uma opção: ");
            var res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Somar(); break;
                case 2: Subtrair(); break;
                case 3: Dividir(); break;
                case 4: Multiplicar(); break;
                case 9: System.Environment.Exit(0); break;
            }
            Menu();
        }
        static void Somar()
        {
            Console.Clear();

            Console.WriteLine("Somar 2 valores.....");
            Console.WriteLine("Primeiro valor:");
            var vlr1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            var vlr2 = float.Parse(Console.ReadLine());

            var resultado = vlr1 + vlr2;

            Console.WriteLine($"O resultado da soma é: {resultado}");
            Console.ReadKey();
        }
        static void Subtrair()
        {
            Console.Clear();

            Console.WriteLine("Subtrair 2 valores.....");
            Console.WriteLine("Primeiro valor:");
            var vlr1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            var vlr2 = float.Parse(Console.ReadLine());

            var resultado = vlr1 - vlr2;

            Console.WriteLine($"O resultado da subtração é: {resultado}");
            Console.ReadKey();
        }
        static void Dividir()
        {
            Console.Clear();

            Console.WriteLine("Dividir 2 valores.....");
            Console.WriteLine("Primeiro valor:");
            var vlr1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            var vlr2 = float.Parse(Console.ReadLine());

            var resultado = vlr1 / vlr2;

            Console.WriteLine($"O resultado da divisão é: {resultado}");
            Console.ReadKey();
        }
        static void Multiplicar()
        {
            Console.Clear();

            Console.WriteLine("Multiplicar 2 valores.....");
            Console.WriteLine("Primeiro valor:");
            var vlr1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            var vlr2 = float.Parse(Console.ReadLine());

            var resultado = vlr1 * vlr2;

            Console.WriteLine($"O resultado da multiplicação é: {resultado}");
            Console.ReadKey();
        }

    }
}

