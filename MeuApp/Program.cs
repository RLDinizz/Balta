using System;

namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var mouse = new Product(1235446, "Gamer", 359.90, EProductType.Product);
            var manutencaoPC = new Product(1235447, "Formatar PC", 50.90, EProductType.Service);

            Console.WriteLine(mouse.Id);
            Console.WriteLine(mouse.Name);
            Console.WriteLine(mouse.Price);
            Console.WriteLine(mouse.Type);


            // Console.WriteLine(mouse.PriceInDolar(5.12));


        }
    }

    struct Product
    {
        public Product(int id, string name, double price, EProductType type)
        {
            Id = id;
            Name = name;
            Price = price;
            Type = type;

        }

        public int Id;
        public string Name;
        public double Price;
        public EProductType Type;

        public double PriceInDolar(double dolar)
        {
            return Price * dolar;
        }
    }

    enum EProductType
    {
        Product = 1,
        Service = 2,
    }


}
