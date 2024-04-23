using POS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS
{
    internal class ProductDao
    {
        //Singleton Data Access Object pattern 
        //Restricts to only one instance of EmployeeDao
        //used as an object to access the datastore files
        private static ProductDao _Instance;

        //collection for header rows in file interactions
        private List<string> Header;
        public List<Product> Products { get; set; }

        private string filePath = "ProductTable.txt";

        public ProductDao()
        {
            Products = new List<Product>();
            LoadDataFromFile();
        }

        //Getter for the private static instance
        public static ProductDao Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new ProductDao();
                }
                return _Instance;
            }
        }

        public void LoadDataFromFile()
        {
            Products.Clear();

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    bool isHeader = true;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(';');
                        if (isHeader)
                        {
                            Header = parts.ToList();
                            isHeader = false;
                        }
                        else if (!isHeader && parts.Length == 5)
                        {
                            ProductCategory foundCategory = null;
                            foreach (ProductCategory c in ProductCategoryDao.Instance.ProductCategories)
                            {
                                if (c.Id.Equals(parts[4]))
                                {
                                    foundCategory = c;
                                    break;
                                }
                            }

                            Product product = new Product(parts[0], parts[1], Convert.ToInt32(parts[2]), Convert.ToDouble(parts[3]), foundCategory);
                            Products.Add(product);
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
            StringBuilder fileContent = new StringBuilder();
            fileContent.AppendLine(string.Join(";", Header));

            foreach (Product product in Products)
            {
                fileContent.AppendLine($"{product.Id};{product.Name};{product.Stock};{product.Price};{product.Category.Id}");
            }

            File.WriteAllText(filePath, fileContent.ToString());
        }

        public DataTable ToDataTable()
        {
            DataTable dt = new DataTable();

            foreach (string h in Header)
            {
                dt.Columns.Add(h);
            }

            foreach (Product product in Products)
            {
                DataRow dr = dt.NewRow();

                dr[0] = product.Id;
                dr[1] = product.Name;
                dr[2] = product.Stock;
                dr[3] = product.Price;
                dr[4] = product.Category.Name;

                dt.Rows.Add(dr);
            }

            return dt;
        }
    }
}
