using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.Models
{
    public class DictionaryStorage : IModelStorage
    {
        Dictionary<string, Product> products = new Dictionary<string, Product>();

        public Product this[string key]
        {
            get { return products[key]; }
            set { products[key] = value; }
        }
        public IEnumerable<Product> Items => products.Values;

        public bool ContainsKey(string key)
        {
           return products.ContainsKey(key);         
        }

        public void RemoveItem(string key)
        {
            products.Remove(key);
        }
    }
}
