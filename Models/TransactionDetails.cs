using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS
{
    internal class TransactionDetails
    {
        public string Id { get; set; }
        public Transaction Transaction { get; set; }
        public Product Product { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public double Subtotal { get; set; }

        public TransactionDetails(string id, Transaction transaction, Product product, double price, int quantity, double subtotal)
        {
            Id = id;
            Transaction = transaction;
            Product = product;
            Price = price;
            Quantity = quantity;
            Subtotal = subtotal;
        }
    }
}
