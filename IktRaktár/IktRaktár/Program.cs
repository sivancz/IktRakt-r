using IktRaktár.Models;
using System;
using System.Collections;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace IktRaktár
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Storage storage = new Storage();

            storage.Add(new Product(1, "Ceruza", 100));
            storage.Add(new Product(2, "Toll", 50));

            while (true)
            {
                Console.WriteLine("\nVálassz funkciót:");
                Console.WriteLine("1 - Teljes lista");
                Console.WriteLine("2 - Keresés ID alapján");
                Console.WriteLine("3 - Keresés név részlet alapján");
                Console.WriteLine("0 - Kilépés");
                Console.Write("Választásod: ");
                string input = Console.ReadLine();

                if (input == "1")
                {
                    Console.WriteLine("Teljes lista:");
                    PrintTable(storage.FindAll(string.Empty)); 
                }
                else if (input == "2")
                {
                    Console.Write("Add meg az ID-t: ");
                    string idInput = Console.ReadLine();
                    if (int.TryParse(idInput, out int keresettId))
                    {
                        var found = storage.FindById(keresettId);
                        if (found != null)
                        {
                            Console.WriteLine("Keresett termék:");
                            PrintTable(new List<Product> { found });
                        }
                        else
                        {
                            Console.WriteLine("Nem található ilyen ID.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Érvénytelen ID.");
                    }
                }
                else if (input == "3")
                {
                    Console.Write("Add meg a név részletet: ");
                    string namePart = Console.ReadLine();
                    var results = storage.FindAll(namePart);
                    if (results.Any())
                    {
                        Console.WriteLine("Találatok:");
                        PrintTable(results);
                    }
                    else
                    {
                        Console.WriteLine("Nincs találat.");
                    }
                }
                else if (input == "0")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Érvénytelen választás.");
                }
            }

            Console.WriteLine("Kilépéshez nyomj egy gombot...");
            Console.ReadKey();
        }

        public static void PrintTable(IEnumerable<Product> list)
        {
            Console.WriteLine("ID | Név        | Készlet");
            Console.WriteLine("----------------------------");
            foreach (var item in list)
            {
                if (item is Product product)
                {
                    Console.WriteLine($"{product.Id,-2} | {product.Name,-10} | {product.Quantity}");
                }
            }
        }

    }
}