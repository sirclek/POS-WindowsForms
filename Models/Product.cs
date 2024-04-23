using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace POS
{
    internal class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public double Price { get; set; }
        public ProductCategory Category { get; set; }

        public Product(string id, string name, int stock, double price, ProductCategory category)
        {
            Id = id;
            Name = name;
            Stock = stock;
            Price = price;
            Category = category;
        }
    }
}
