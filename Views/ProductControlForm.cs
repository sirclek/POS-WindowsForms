using POS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class ProductControlForm : Form
    {
        private int EditIndex = -1;
        public ProductControlForm()
        {
            InitializeComponent();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            RefreshTable();
            ComboBoxCategory.DataSource = ProductCategoryDao.Instance.ProductCategories;
            ComboBoxCategory.SelectedItem = ProductCategoryDao.Instance.ProductCategories.First();
            ComboBoxCategory.DisplayMember = "Name";

        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            if (EditIndex == -1)
            {
                if (TextBoxName.Text.Length == 0 || NumericUpDownPrice.Text.Length == 0 || NumericUpDownStock.Text.Length == 0)
                {
                    MessageBox.Show("Please fill out the input form!");
                }
                else
                {
                    ProductCategory temp = ProductCategoryDao.Instance.ProductCategories.First();

                    foreach (ProductCategory category in ProductCategoryDao.Instance.ProductCategories)
                    {
                        if (category.Name.Equals(ComboBoxCategory.Text))
                        {
                            temp = category;
                        }
                    }


                    ProductDao.Instance.Products.Add(new Product(Guid.NewGuid().ToString(), TextBoxName.Text, Convert.ToInt32(NumericUpDownStock.Text), Convert.ToInt32(NumericUpDownPrice.Text), temp));
                    ProductDao.Instance.SaveDataToFile();
                    TextBoxName.Text = "";
                    NumericUpDownPrice.Text = "";
                    NumericUpDownStock.Text = "";

                    RefreshTable();
                }
            }
            else
            {
                ProductDao.Instance.Products[EditIndex].Name = TextBoxName.Text;
                ProductDao.Instance.Products[EditIndex].Stock = Convert.ToInt32(NumericUpDownStock.Text);
                ProductDao.Instance.Products[EditIndex].Price = Convert.ToInt32(NumericUpDownPrice.Text);
                ProductCategory temp2 = ProductCategoryDao.Instance.ProductCategories.First();

                foreach (ProductCategory category in ProductCategoryDao.Instance.ProductCategories)
                {
                    if (category.Name.Equals(ComboBoxCategory.Text))
                    {
                        temp2 = category;
                    }
                }
                ProductDao.Instance.Products[EditIndex].Category = temp2;
                ProductDao.Instance.SaveDataToFile();
                TextBoxName.Text = "";
                NumericUpDownStock.Text = "";
                NumericUpDownPrice.Text = "";
                RefreshTable();

                // Reset edit index
                EditIndex = -1;
                ButtonSubmit.Text = "Create";
                CancelEditButton.Hide();
            }
        }

        private void RefreshTable()
        {
            DataTable dataTable = ProductDao.Instance.ToDataTable();

            dataTable.Columns.Add("Action Update");
            dataTable.Columns.Add("Action Delete");

            foreach (DataRow row in dataTable.Rows)
            {
                row["Action Update"] = "Update";
                row["Action Delete"] = "Delete";
            }

            DataGridViewProduct.DataSource = dataTable;
            DataGridViewUtils.LockSortMode(DataGridViewProduct);

        }

        private void CancelEditButton_Click(object sender, EventArgs e)
        {
            EditIndex = -1;
            ButtonSubmit.Text = "Create";
            TextBoxName.Text = "";
            NumericUpDownStock.Text = "";
            NumericUpDownPrice.Text = "";

            CancelEditButton.Hide();
        }

        private void DataGridViewProduct_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string cellValue = DataGridViewProduct.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                if (cellValue == "Update")
                {
                    TextBoxName.Text = DataGridViewProduct.Rows[e.RowIndex].Cells[DataGridViewProduct.Columns["Name"].Index].Value.ToString();
                    NumericUpDownPrice.Text = DataGridViewProduct.Rows[e.RowIndex].Cells[DataGridViewProduct.Columns["Price"].Index].Value.ToString();
                    NumericUpDownStock.Text = DataGridViewProduct.Rows[e.RowIndex].Cells[DataGridViewProduct.Columns["Stock"].Index].Value.ToString();
                    ComboBoxCategory.Text = DataGridViewProduct.Rows[e.RowIndex].Cells[DataGridViewProduct.Columns["Category"].Index].Value.ToString();


                    EditIndex = e.RowIndex;
                    ButtonSubmit.Text = "Edit";
                    CancelEditButton.Show();
                }
                else if (cellValue == "Delete")
                {
                    var result = MessageBox.Show("Do you want to delete this product?", "Confirmation", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        ProductDao.Instance.Products.RemoveAt(e.RowIndex);
                        ProductDao.Instance.SaveDataToFile();
                        this.RefreshTable();
                    }
                }
            }
        }
    }
}