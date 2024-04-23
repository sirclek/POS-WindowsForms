using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS
{
    internal class ProductCategory
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ProductCategory(string id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }

        public ProductCategory GetProductCategory(string name)
        {
            return this.GetProductCategory(name) ;
        }
    }
}
