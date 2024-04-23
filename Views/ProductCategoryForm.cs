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
    public partial class ProductCategoryForm : Form
    {
        private int EditIndex = -1;

        public ProductCategoryForm()
        {
            InitializeComponent();
        }

        private void ProductCategoryForm_Load(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            if (EditIndex == -1)
            {
                if (TextBoxName.Text.Length == 0 || TextBoxDescription.Text.Length == 0)
                {
                    MessageBox.Show("Please fill out the input form!");
                }
                else
                {
                    ProductCategoryDao.Instance.ProductCategories.Add(new ProductCategory(Guid.NewGuid().ToString(), TextBoxName.Text, TextBoxDescription.Text));
                    ProductCategoryDao.Instance.SaveDataToFile();
                    TextBoxName.Text = "";
                    TextBoxDescription.Text = "";
                    RefreshTable();
                }
            }
            else
            {
                ProductCategoryDao.Instance.ProductCategories[EditIndex].Name = TextBoxName.Text;
                ProductCategoryDao.Instance.ProductCategories[EditIndex].Description = TextBoxDescription.Text;
                ProductCategoryDao.Instance.SaveDataToFile();
                TextBoxName.Text = "";
                TextBoxDescription.Text = "";
                RefreshTable();

                EditIndex = -1;
                ButtonSubmit.Text = "Create";
                ButtonCancelEdit.Hide();
            }
        }

        private void RefreshTable()
        {
            DataTable dataTable = ProductCategoryDao.Instance.ToDataTable();
            dataTable.Columns.Add("Action Update");
            dataTable.Columns.Add("Action Delete");

            foreach (DataRow row in dataTable.Rows)
            {
                row["Action Update"] = "Update";
                row["Action Delete"] = "Delete";
            }

            DataGridViewProductCategory.DataSource = dataTable;
            DataGridViewUtils.LockSortMode(DataGridViewProductCategory);

        }

        private void DataGridViewProductCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string cellValue = DataGridViewProductCategory.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                if (cellValue == "Update")
                {
                    TextBoxName.Text = DataGridViewProductCategory.Rows[e.RowIndex].Cells[DataGridViewProductCategory.Columns["Name"].Index].Value.ToString();
                    TextBoxDescription.Text = DataGridViewProductCategory.Rows[e.RowIndex].Cells[DataGridViewProductCategory.Columns["Description"].Index].Value.ToString();

                    EditIndex = e.RowIndex;
                    ButtonSubmit.Text = "Edit";
                    ButtonCancelEdit.Show();
                }
                else if (cellValue == "Delete")
                {
                    var result = MessageBox.Show("Do you want to delete this category?", "Confirmation", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        ProductCategoryDao.Instance.ProductCategories.RemoveAt(e.RowIndex);
                        ProductCategoryDao.Instance.SaveDataToFile();
                        this.RefreshTable();
                    }
                }
            }
        }

        private void ButtonCancelEdit_Click(object sender, EventArgs e)
        {
            EditIndex = -1;
            ButtonSubmit.Text = "Create";
            TextBoxName.Text = "";
            TextBoxDescription.Text = "";
            ButtonCancelEdit.Hide();
        }
    }
}
