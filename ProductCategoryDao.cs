using POS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace POS
{
    internal class ProductCategoryDao
    {
        private static ProductCategoryDao _Instance;
        private List<string> Header;
        public List<ProductCategory> ProductCategories { get; set; }

        private string filePath = "ProductCategoryTable.txt";

        public ProductCategoryDao()
        {
            ProductCategories = new List<ProductCategory>();
            LoadDataFromFile();
        }

        public static ProductCategoryDao Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new ProductCategoryDao();
                }
                return _Instance;
            }
        }

        public void LoadDataFromFile()
        {
            ProductCategories.Clear();

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
                        else if (!isHeader && parts.Length == 3)
                        {
                            ProductCategory productCategory = new ProductCategory(parts[0], parts[1], parts[2]);
                            ProductCategories.Add(productCategory);
                        }
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine($"An error occurred while reading the file: {e.Message}");
            }
        }

        //This method is used to update the content of the file by first saving updated information in the data layer, before clearing
        //and pasting that update into the file. 
        public void SaveDataToFile()
        {
            StringBuilder fileContent = new StringBuilder();
            fileContent.AppendLine(string.Join(";", Header));

            foreach (var productCategory in ProductCategories)
            {
                fileContent.AppendLine($"{productCategory.Id};{productCategory.Name};{productCategory.Description}");
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

            foreach (ProductCategory pc in ProductCategories)
            {
                DataRow dr = dt.NewRow();

                dr[0] = pc.Id;
                dr[1] = pc.Name;
                dr[2] = pc.Description;

                dt.Rows.Add(dr);
            }

            return dt;
        }


    }
}
