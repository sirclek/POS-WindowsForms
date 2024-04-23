using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS;

namespace POS
{
    internal class Transaction
    {
        public string Id { get; set; }
        public string CustomerName { get; set; }
        public double Total { get; set; }
        public DateTime Timestamp { get; set; }
        public List<TransactionDetails> Details { get; set; }

        public Transaction()
        {
            Id = Guid.NewGuid().ToString();
            Details = new List<TransactionDetails>();

        }

        public Transaction(string id, string customerName, double total, DateTime timestamp)
        {
            Id = id;
            CustomerName = customerName;
            Total = total;
            Timestamp = timestamp;
            Details = new List<TransactionDetails>();
        }
    }
}
