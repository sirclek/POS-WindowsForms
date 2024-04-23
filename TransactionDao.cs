using POS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace POS
{
    internal class TransactionDao
    {
        //Singleton Data Access Object Instance
        //Restricts to only one instance of TransactionDAO
        //used as an object to access the datastore files
        private static TransactionDao _Instance;

         //Reusable collection for datatable headers

        //list manipulate data from transactiontables   
        private List<string> HeaderTransaction;
        //list to manipulate data from transactiondetailstables
        private List<string> HeaderTransactionDetails;
        public List<Transaction> Transactions { get; set; }

        private string TransactionFilePath = "TransactionTable.txt";
        private string TransactionDetailsFilePath = "TransactionDetailsTable.txt";

        public TransactionDao()
        {
            Transactions = new List<Transaction>();
            LoadDataFromFile();
        }

        //Getter for the private static instance
        public static TransactionDao Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new TransactionDao();
                }
                return _Instance;
            }
        }

        public void LoadDataFromFile()
        {
            Transactions.Clear();

            try
            {
                using (StreamReader reader = new StreamReader(TransactionFilePath))
                {
                    string line;
                    bool isHeader = true;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(';');
                        if (isHeader)
                        {
                            HeaderTransaction = parts.ToList();
                            isHeader = false;
                        }
                        else if (!isHeader && parts.Length == 4)
                        {
                            Transaction transaction = new Transaction(parts[0], parts[1], Convert.ToDouble(parts[2]), DateTime.Parse(parts[3]));
                            Transactions.Add(transaction);
                        }
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine($"An error occurred while reading the file: {e.Message}");
            }

            try
            {
                using (StreamReader reader = new StreamReader(TransactionDetailsFilePath))
                {
                    string line;
                    bool isHeader = true;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(';');
                        if (isHeader)
                        {
                            HeaderTransactionDetails = parts.ToList();
                            isHeader = false;
                        }
                        else if (!isHeader && parts.Length == 6)
                        {
                            Transaction foundTransaction = null;
                            Product foundProduct = null;

                            foreach (Transaction t in Transactions)
                            {
                                if (t.Id.Equals(parts[1]))
                                {
                                    foundTransaction = t;
                                    break;
                                }
                            }
                            foreach (Product p in ProductDao.Instance.Products)
                            {
                                if (p.Id.Equals(parts[2]))
                                {
                                    foundProduct = p;
                                    break;
                                }
                            }

                            TransactionDetails transactionDetails = new TransactionDetails(parts[0], foundTransaction, foundProduct, Convert.ToDouble(parts[4]), Convert.ToInt32(parts[3]), Convert.ToDouble(parts[5]));
                            Transactions.First(item => item.Id == parts[1]).Details.Add(transactionDetails);
                        }
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine($"An error occurred while reading the file: {e.Message}");
            }
        }

        public void SaveDataToFile()
        {
            StringBuilder fileContent;

            fileContent = new StringBuilder();
            fileContent.AppendLine(string.Join(";", HeaderTransaction));

            foreach (Transaction transaction in Transactions)
            {
                fileContent.AppendLine($"{transaction.Id};{transaction.CustomerName};{transaction.Total};{transaction.Timestamp}");
            }

            File.WriteAllText(TransactionFilePath, fileContent.ToString());

            fileContent = new StringBuilder();
            fileContent.AppendLine(string.Join(";", HeaderTransactionDetails));

            foreach (Transaction transaction in Transactions)
            {
                foreach (TransactionDetails details in transaction.Details)
                    fileContent.AppendLine($"{details.Id};{details.Transaction.Id};{details.Product.Id};{details.Quantity};{details.Price};{details.Subtotal}");
            }

            File.WriteAllText(TransactionDetailsFilePath, fileContent.ToString());
        }

        public DataTable ToDataTable()
        {
            DataTable dt = new DataTable();

            foreach (string h in HeaderTransaction)
            {
                dt.Columns.Add(h);
            }

            foreach (Transaction transaction in Transactions)
            {
                DataRow dr = dt.NewRow();

                dr[0] = transaction.Id;
                dr[1] = transaction.CustomerName;
                dr[2] = transaction.Total;
                dr[3] = transaction.Timestamp;

                dt.Rows.Add(dr);
            }

            return dt;
        }

        public DataTable ToTransactionDetailsDataTable(List<TransactionDetails> Details)
        {
            DataTable dt = new DataTable();

            foreach (string h in HeaderTransactionDetails)
            {
                dt.Columns.Add(h);
            }

            foreach (TransactionDetails details in Details)
            {
                DataRow dr = dt.NewRow();

                dr[0] = details.Id;
                dr[1] = details.Transaction.Id;
                dr[2] = details.Product.Name;
                dr[3] = details.Quantity;
                dr[4] = details.Price;
                dr[5] = details.Subtotal;

                dt.Rows.Add(dr);
            }

            return dt;
        }
    }
}
