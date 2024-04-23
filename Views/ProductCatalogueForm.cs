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
    public partial class ProductCatalogueForm : Form
    {

        public ProductCatalogueForm()
        {
            InitializeComponent();
        }

        private void ProductCatalogueForm_Load(object sender, EventArgs e)
        {
            RefreshTable();

            ComboBoxProductCategory.DataSource = ProductCategoryDao.Instance.ProductCategories;
            ComboBoxProductCategory.SelectedItem = ProductCategoryDao.Instance.ProductCategories.First();
            ComboBoxProductCategory.DisplayMember = "Name";
        }


        private void RefreshTable()
        {
            DataTable dataTable = ProductDao.Instance.ToDataTable();

            DataGridViewCatalogue.DataSource = dataTable;
            DataGridViewUtils.LockSortMode(DataGridViewCatalogue);
        }

        private void ButtonFilter_Click(object sender, EventArgs e)
        {

            BindingSource bs = new BindingSource();
            bs.DataSource = DataGridViewCatalogue.DataSource;
            bs.Filter = DataGridViewCatalogue.Columns[1].HeaderText.ToString() + " LIKE '%" + TextBoxProductName.Text + "%'";
            DataGridViewCatalogue.DataSource = bs;

        }

        private void ButtonFilterCategory_Click(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = DataGridViewCatalogue.DataSource;
            bs.Filter = DataGridViewCatalogue.Columns[4].HeaderText.ToString() + " LIKE '%" + ComboBoxProductCategory.Text + "%'";
            DataGridViewCatalogue.DataSource = bs;
        }
    }
}
