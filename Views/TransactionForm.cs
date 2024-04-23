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
    public partial class TransactionForm : Form
    {
        private Transaction ChosenTransaction;
        private int limit = TransactionDao.Instance.Transactions.Count;

        public TransactionForm()
        {
            InitializeComponent();
        }

        private void ButtonCreateTransaction_Click(object sender, EventArgs e)
        {
            CreateTransactionForm createTransactionForm = new CreateTransactionForm();
            createTransactionForm.ShowDialog();
        }

        private void TransactionForm_Load(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private void TransactionForm_Activated(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private void RefreshTable()
        {
            TransactionDao.Instance.LoadDataFromFile();
            DataGridViewTransaction.DataSource = TransactionDao.Instance.ToDataTable();
            DataGridViewUtils.LockSortMode(DataGridViewTransaction);
        }

        private void DataGridViewTransaction_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //limit to avoid input errors when clicking on empty row. 
            if (e.RowIndex >= 0 && e.RowIndex < limit)
            {
                DataGridViewRow selectedRow = DataGridViewTransaction.Rows[e.RowIndex];
                string id = selectedRow.Cells["ID"].Value.ToString();
                ChosenTransaction = TransactionDao.Instance.Transactions.First(item => item.Id == id);

                TransactionDetailsForm transactionDetailsForm = new TransactionDetailsForm(ChosenTransaction.Id);
                transactionDetailsForm.Show();

            }
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = DataGridViewTransaction.DataSource;
            bs.Filter = "[" + DataGridViewTransaction.Columns[1].HeaderText.ToString() + "] LIKE '%" + TextBoxName.Text + "%'";
            DataGridViewTransaction.DataSource = bs;
            limit = DataGridViewTransaction.Rows.Count - 1;

        }
    }
}
