using IktRaktár.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IktRaktár.Models
{
    internal class Storage : ISearchable<Product>
    {
        private List<Product> items = new List<Product>();

        public void Add(Product product)
        {
            items.Add(product);
        }


        
        public IEnumerable<Product> FindAll(string name)
        {
            List<Product> searchedProducts = new List<Product>();
            foreach (Product product in items)
            {
                if (product.Name.Contains(name, StringComparison.CurrentCultureIgnoreCase))
                {
                    searchedProducts.Add(product);
                }
            }
            return searchedProducts;
        }

        public Product? FindById(int id)
        {
            foreach (var item in items)
            {
                if (item.Id == id) return item;

            }
            return null;
        }


    }


}
