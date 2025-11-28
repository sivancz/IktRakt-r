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



        }
    }
}
