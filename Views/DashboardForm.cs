using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using POS;

namespace POS
{
    public partial class DashboardForm : Form
    {
        private DataTable pSalesDataTable, frequencyDataTable, cSalesDataTable;
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            //AuthenticatedEmployee.GetInstance().AuthenticatedEmployeeData cannot be null
            Employee employee = AuthenticatedEmployee.GetInstance().AuthenticatedEmployeeData!;
            LabelAuthenticatedEmployee.Text = "Hello, " + AuthenticatedEmployee.GetInstance().AuthenticatedEmployeeData!.Name;
            LabelDate.Text = "Today's date is " + DateTime.Now.ToString();

            if (employee.Role != "admin")
            {
                btnMenuUsers.Hide();
                btnMenuProduct.Hide();
                btnMenuProductCategory.Hide();
                lblUsers.Hide();
            }
            LabelTotalSales.Text = "Total Sales: $" + SaleProcessor.GetTotalSales().ToString();
            RefreshDataTable();
            RefreshChart();
        }

        private void RefreshDataTable()
        {
            pSalesDataTable = SaleProcessor.GetHighestProductSalesTable();
            DataGridViewProductSales.DataSource = pSalesDataTable;
            DataGridViewUtils.LockSortMode(DataGridViewProductSales);

            frequencyDataTable = SaleProcessor.GetHighestProductFrequencyTable();
            DataGridViewProductFrequency.DataSource = frequencyDataTable;
            DataGridViewUtils.LockSortMode(DataGridViewProductFrequency);

            cSalesDataTable = SaleProcessor.GetHighestCategorySalesTable();
            DataGridViewCategorySales.DataSource = cSalesDataTable;
            DataGridViewUtils.LockSortMode(DataGridViewCategorySales);

        }

        private void RefreshChart()
        {
            //Product Sales stuff.

            List<string> salesProductName = new List<string>();

            foreach (DataRow row in pSalesDataTable.Rows)
            {
                salesProductName.Add(row["Product Name"].ToString());
            }

            List<double> salesProductRevenue = new List<double>();

            foreach (DataRow row in pSalesDataTable.Rows)
            {
                salesProductRevenue.Add(Convert.ToDouble(row["Total Sales ($)"]));
            }

            ChartTopProductsBySales.Series.Clear();
            ChartTopProductsBySales.Titles.Clear();

            Series salesSeries = new Series("Doughnut");
            salesSeries.ChartType = SeriesChartType.Doughnut;

            salesSeries.Points.DataBindXY(salesProductName.ToArray(), salesProductRevenue.ToArray());

            ChartTopProductsBySales.Palette = ChartColorPalette.Excel;
            salesSeries.IsValueShownAsLabel = true;
            salesSeries.Label = "#VALX";
            salesSeries.LegendText = "#VALX (#PERCENT{P0})";

            ChartTopProductsBySales.Titles.Add(new Title("Top Product Sales", Docking.Top, new Font("Segoe UI", 12), Color.Black));
            ChartTopProductsBySales.Series.Add(salesSeries);

            //Product Frequency stuff. 

            List<string> frequencyProductName = new List<string>();

            foreach (DataRow row in frequencyDataTable.Rows)
            {
                frequencyProductName.Add(row["Product Name"].ToString());
            }

            List<double> freqencyProductCount = new List<double>();

            foreach (DataRow row in frequencyDataTable.Rows)
            {
                freqencyProductCount.Add(Convert.ToInt32(row["Frequency of Sales"]));
            }

            ChartTopProductsByFrequency.Series.Clear();
            ChartTopProductsByFrequency.Titles.Clear();

            Series frequencySeries = new Series("Doughnut");
            frequencySeries.ChartType = SeriesChartType.Doughnut;

            frequencySeries.Points.DataBindXY(frequencyProductName.ToArray(), freqencyProductCount.ToArray());

            ChartTopProductsBySales.Palette = ChartColorPalette.Pastel;
            frequencySeries.IsValueShownAsLabel = true;
            frequencySeries.Label = "#VALX";
            frequencySeries.LegendText = "#VALX (#PERCENT{P0})";

            ChartTopProductsByFrequency.Titles.Add(new Title("Top Product Frequency", Docking.Top, new Font("Segoe UI", 12), Color.Black));
            ChartTopProductsByFrequency.Series.Add(frequencySeries);

            //Category Sales stuff.

            List<string> salesCategoryName = new List<string>();

            foreach (DataRow row in cSalesDataTable.Rows)
            {
                salesCategoryName.Add(row["Category Name"].ToString());
            }

            List<double> salesCategoryRevenue = new List<double>();

            foreach (DataRow row in cSalesDataTable.Rows)
            {
                salesCategoryRevenue.Add(Convert.ToDouble(row["Total Sales ($)"]));
            }

            ChartTopCategoriesBySales.Series.Clear();
            ChartTopCategoriesBySales.Titles.Clear();

            Series categorySalesSeries = new Series("Doughnut");
            categorySalesSeries.ChartType = SeriesChartType.Doughnut;

            categorySalesSeries.Points.DataBindXY(salesCategoryName.ToArray(), salesCategoryRevenue.ToArray());

            ChartTopCategoriesBySales.Palette = ChartColorPalette.Excel;
            categorySalesSeries.IsValueShownAsLabel = true;
            categorySalesSeries.Label = "#VALX";
            categorySalesSeries.LegendText = "#VALX (#PERCENT{P0})";

            ChartTopCategoriesBySales.Titles.Add(new Title("Top Category", Docking.Top, new Font("Segoe UI", 12), Color.Black));
            ChartTopCategoriesBySales.Series.Add(categorySalesSeries);



        }

        // btnMenuProductCategory
        private void btnMenuProductCategory_Click(object sender, EventArgs e)
        {
            ProductCategoryForm productCategoryForm = new ProductCategoryForm();
            productCategoryForm.ShowDialog();
        }

        // btnMenuProduct
        private void btnMenuProduct_Click(object sender, EventArgs e)
        {
            ProductControlForm productForm = new ProductControlForm();
            productForm.ShowDialog();
        }

        // btnMenuUsers
        private void btnMenuUsers_Click(object sender, EventArgs e)
        {
            UserForm userform = new UserForm();
            userform.ShowDialog();
        }

        // btnMenuTransaction
        private void btnMenuTransaction_Click(object sender, EventArgs e)
        {
            TransactionForm transactionForm = new TransactionForm();
            transactionForm.ShowDialog();

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnProductCatalogue_Click(object sender, EventArgs e)
        {
            ProductCatalogueForm catalogueForm = new ProductCatalogueForm();
            catalogueForm.ShowDialog();
        }

        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            RefreshDataTable();
            RefreshChart();
        }

        private void ButtonLogOut_Click(object sender, EventArgs e)
        {
            AuthenticatedEmployee.GetInstance().Logout();
            this.Close();
        }
    }
}
