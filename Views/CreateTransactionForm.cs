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
    public partial class CreateTransactionForm : Form
    {
        private Product ChosenProduct;
        private Transaction Transaction;
        private int limit = ProductDao.Instance.Products.Count;

        public CreateTransactionForm()
        {
            InitializeComponent();
        }

        private void TransactionForm_Load(object sender, EventArgs e)
        {
            DataGridViewProduct.DataSource = ProductDao.Instance.ToDataTable();
            DataGridViewUtils.LockSortMode(DataGridViewProduct);
            Transaction = new Transaction();
        }

        private void DataGridViewProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < limit)
            {
                DataGridViewRow selectedRow = DataGridViewProduct.Rows[e.RowIndex];
                string id = selectedRow.Cells["ID"].Value.ToString();
                ChosenProduct = ProductDao.Instance.Products.First(item => item.Id == id);
                TextBoxProduct.Text = ChosenProduct.Name;
                NumericInputQuantity.Maximum = ChosenProduct.Stock;
            }
        }

        private void ButtonAddToTransaction_Click(object sender, EventArgs e)
        {
            //Error prevention so users cant add more stock than what is available. 
            foreach (TransactionDetails d in Transaction.Details)
            {
                if (d.Product == ChosenProduct)
                {
                    if (NumericInputQuantity.Value + d.Quantity > ChosenProduct.Stock)
                    {
                        MessageBox.Show("Not enough product stock");
                        return;
                    }
                }
            }

            if (NumericInputQuantity.Value > ChosenProduct.Stock)
            {
                MessageBox.Show("Quantity cannot be more than stock");
            }
            if (NumericInputQuantity.Value <= 0)
            {
                MessageBox.Show("Quantity cannot be 0.");
            }
            else if (ChosenProduct == null)
            {
                MessageBox.Show("Please select a product.");
            }
            else
            {
                int quantity = Convert.ToInt32(NumericInputQuantity.Value);
                double subtotal = ChosenProduct.Price * quantity;

                foreach (TransactionDetails d in Transaction.Details)
                {
                    if (d.Product == ChosenProduct)
                    {
                        if (d.Quantity > d.Product.Stock - 1)
                        {
                            MessageBox.Show("Quantity is bigger than stock");
                            return;
                        }
                    }
                }

                foreach (TransactionDetails d in Transaction.Details)
                {
                    if (d.Product.Equals(ChosenProduct))
                    {
                        d.Quantity += quantity;
                        d.Subtotal += subtotal;
                        RefreshTable();
                        return;
                    }
                }

                TransactionDetails detail = new TransactionDetails(Guid.NewGuid().ToString(), Transaction, ChosenProduct, ChosenProduct.Price, quantity, subtotal);

                Transaction.Details.Add(detail);

                RefreshTable();
            }
        }

        private void RefreshTable()
        {
            NumericInputQuantity.Value = 1;

            DataGridViewTransactionDetails.DataSource = TransactionDao.Instance.ToTransactionDetailsDataTable(Transaction.Details);
            DataGridViewUtils.LockSortMode(DataGridViewTransactionDetails);

            double total = 0;

            for (int i = 0; i < Transaction.Details.Count; i++)
            {
                double subtotal = Transaction.Details[i].Price * Transaction.Details[i].Quantity;
                total += subtotal;
            }
            TextBoxProduct.Text = "";
            ChosenProduct = null;
            //Refreshes total price aswell
            TextBoxTotal.Text = total.ToString();

        }

        private void ButtonSaveTransaction_Click(object sender, EventArgs e)
        {
            if (Transaction.Details.Count == 0)
            {
                MessageBox.Show("No transaction is being done. ");
            }
            else if (TextBoxCustomerName.Text.Length == 0)
            {
                MessageBox.Show("Customer name cannot be empty. ");
            }
            else
            {
                var result = MessageBox.Show("Are you sure you want to save this transaction?", "Confirmation", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    double total = 0;
                    for (int i = 0; i < Transaction.Details.Count; i++)
                    {
                        ProductDao.Instance.Products.First(item => item.Id == Transaction.Details[i].Product.Id).Stock -= Transaction.Details[i].Quantity;
                        double subtotal = Transaction.Details[i].Price * Transaction.Details[i].Quantity;
                        total += subtotal;
                    }

                    Transaction.CustomerName = TextBoxCustomerName.Text;
                    Transaction.Total = total;
                    Transaction.Timestamp = DateTime.Now;

                    TransactionDao.Instance.Transactions.Add(Transaction);
                    TransactionDao.Instance.SaveDataToFile();
                    ProductDao.Instance.SaveDataToFile();
                    this.Close();
                }
            }
        }

        private void TextBoxProduct_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = DataGridViewProduct.DataSource;
            bs.Filter = "[" + DataGridViewProduct.Columns[1].HeaderText.ToString() + "] LIKE '%" + TextBoxProduct.Text + "%'";
            DataGridViewProduct.DataSource = bs;
            limit = DataGridViewProduct.Rows.Count - 1;
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            Transaction.Details.Clear();
            RefreshTable();
        }
    }
}

