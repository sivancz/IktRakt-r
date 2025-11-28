using iktRaktar.Models;
using IktRaktár.Models;

namespace IktRaktár
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Storage storage = new Storage();

            storage.Add(new Product(1, "Ceruza", 100));
            storage.Add(new Product(2, "Toll", 50));
            storage.Add(new Product(3, "Füzet", 80));

            Console.WriteLine("Raktár rendszer - fejlesztési alap");

            Order order = new Order();
            order.AddItem(storage.FindById(1), 3);
            order.AddItem(storage.FindById(2), 2);

            order.SaveToFile("order_1.txt");



            bool running = true;
            while (running)
            {
                Console.WriteLine();
                Console.WriteLine("4 - készlet növlés");
                Console.WriteLine("5 - készlet csökkentés");
                Console.WriteLine("0 - kilépés");
                Console.WriteLine("Választás");

                string input = Console.ReadLine();
                switch (input)
                {
                    case "4":
                        Console.Write("Ter,ék ID: ");
                        int IdInc = int.Parse(Console.ReadLine());

                        Console.Write("Növelés mértéke: ");
                        int amountInc = int.Parse(Console.ReadLine());

                        storage.IncreaseQuantity(IdInc, amountInc);
                        var pInc = storage.FindById(IdInc);
                        if (pInc != null)
                        {
                            Console.WriteLine($"{pInc.Id} {pInc.Name} új mennyiség: {pInc.Quantity}");
                        }
                        break;

                    case "5":
                        Console.Write("Ter,ék ID: ");
                        int idDec = int.Parse(Console.ReadLine());

                        Console.Write("Csökkentés mértéke: ");
                        int amountDec = int.Parse(Console.ReadLine());

                        storage.DecreaseQuantity(idDec, amountDec);
                        var pDec = storage.FindById(idDec);
                        if (pDec != null)
                        {
                            Console.WriteLine($"{pDec.Id} {pDec.Name} új mennyiség: {pDec.Quantity}");
                        }
                        break;

                    case "0":
                        running = false;
                        break;

                }
            }
        }
    }
}
