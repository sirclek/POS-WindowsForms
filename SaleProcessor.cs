using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using POS;

namespace POS
{
    internal class SaleProcessor
    {
        //Class that returns static lists of objects
        //Required for the data visualization program
        
        public SaleProcessor()
        {
        }
        
        //returns a total amt of type double of overall sales
        public static double GetTotalSales()
        {
            double totalSales = 0;
            List<Transaction> transactions = TransactionDao.Instance.Transactions;
            
            foreach (Transaction t in transactions)
            {
                totalSales += t.Total;
            }

            return totalSales;
        }

        //returns sales amt of type double of a single product
        public static double GetProductSales(Product product)
        {
            List<Transaction> transactions = TransactionDao.Instance.Transactions;
            double productSales = 0;
            
            foreach (Transaction t in transactions)
            {
                foreach (TransactionDetails td in  t.Details)
                {
                    if (td.Product == product)
                    {
                        productSales += td.Quantity * td.Product.Price;
                    }
                }
            }

            return productSales;
        }

        //returns amt sold of type int of a single product
        public static int GetProductFrequency(Product product)
        {
            List<Transaction> transactions = TransactionDao.Instance.Transactions;
            int productFreq = 0;

            foreach (Transaction t in transactions)
            {
                foreach (TransactionDetails td in t.Details)
                {
                    if (td.Product == product)
                    {
                        productFreq++;
                    }
                }
            }

            return productFreq;
        }

        //returns sales amt of type double of a single category
        public static double GetCategorySales(ProductCategory category)
        {
            List<Transaction> transactions = TransactionDao.Instance.Transactions;
            double categorySales = 0;

            foreach(Transaction t in transactions)
            {
                foreach (TransactionDetails td in t.Details)
                {
                    if (td.Product.Category == category)
                    {
                        categorySales += td.Product.Price * td.Quantity;
                    }
                }
            }

            return categorySales;
        }

        //returns an ordered table showing
        //the sales amt per product sorted from high -> low
        public static DataTable GetHighestProductSalesTable() 
        {
            List<Product> products = ProductDao.Instance.Products;
            List<Product> sortedProducts = products.OrderByDescending(p => GetProductSales(p)).ToList();

            DataTable dt = new DataTable();
            dt.Columns.Add("Product Name");
            dt.Columns.Add("Total Sales ($)");


            foreach (Product product in sortedProducts)
            {
                DataRow dr = dt.NewRow();
                dr[0] = product.Name;
                dr[1] = GetProductSales(product);

                dt.Rows.Add(dr);
            }

            return dt;
        }

        //returns an ordered table showing
        //the amt sold per product sorted from high -> low
        public static DataTable GetHighestProductFrequencyTable()
        {
            List<Product> products = ProductDao.Instance.Products;
            List<Product> sortedProducts = products.OrderByDescending(p => GetProductFrequency(p)).ToList();

            DataTable dt = new DataTable();
            dt.Columns.Add("Product Name");
            dt.Columns.Add("Frequency of Sales");

            foreach (Product product in sortedProducts)
            {
                DataRow dr = dt.NewRow();
                dr[0] = product.Name;
                dr[1] = GetProductFrequency(product);

                dt.Rows.Add(dr);
            }

            return dt;
        }

        //returns an ordered table showing
        //the sales amt per category sorted from high -> low
        public static DataTable GetHighestCategorySalesTable() 
        {
            List<ProductCategory> categories = ProductCategoryDao.Instance.ProductCategories;
            List<ProductCategory> sortedCategories = categories.OrderByDescending(c => GetCategorySales(c)).ToList();

            DataTable dt = new DataTable();
            dt.Columns.Add("Category Name");
            dt.Columns.Add("Total Sales ($)");


            foreach (ProductCategory category in sortedCategories)
            {
                DataRow dr = dt.NewRow();
                dr[0] = category.Name;
                dr[1] = GetCategorySales(category);

                dt.Rows.Add(dr);
            }

            return dt;
        }


    }
}
