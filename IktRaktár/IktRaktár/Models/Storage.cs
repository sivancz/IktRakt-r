using IktRaktár.Models.Interfaces;
using IktRaktár.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iktRaktar.Models
{
    private List<Product> items;

    public void Add(Product product)
    {
        items ??= new List<Product>();
        items.Add(product);
    }

    public IEnumerable<Product> FindAll(string name)
    {
        return items?.Where(p => p.Name.Contains(name, StringComparison.OrdinalIgnoreCase)) ?? Enumerable.Empty<Product>();
    }

    public Product? FindById(int id)
    {
        return items?.FirstOrDefault(p => p.Id == id);
    }

        public IEnumerable<Product> FindAll(string name)
        {
            foreach (var item in order.Items)
            {
                var product = storage.FindById(item.Product.Id);
                if (product == null || product.Quantity < item.Quantity)
                {
                    Console.WriteLine($"Hiba: Nincs elegendő készlet a(z) '{item.Product.Name}' termékből. Igényelt: {item.Quantity}, Elérhető: {product?.Quantity ?? 0}");
                    return false;
                }
            }

        public Product? FindById(int Id)
        {
            foreach (var item in items)
            {
                if (item.Id == Id) return item;
            }
            return null;
        }

        public void IncreaseQuantity(int id, int amount)
        {
            Product? product = FindById(id);
            if (product != null)
            {
                product.Quantity += amount;
            }
            else
            {
                Console.WriteLine("Nincs ilyen termék!");
            }
        }
        public void DecreaseQuantity(int id, int amount)
        {
            Product? product = FindById(id);
            if (product != null)
            {
                product.Quantity -= amount;

                if (product.Quantity < 0)
                {
                    product.Quantity = 0;
                }
            }
            else
            {
                Console.WriteLine("Nincs ilyen termék!");
            }
        }

            Console.WriteLine($"Rendelés feldolgozva #{order.Id}");
            Console.WriteLine($"    Levont készlet: {string.Join(", ", levontKeszlet)}");
            return true;
        }
    }



}
