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
    public partial class TransactionDetailsForm : Form
    {
        private string TransactionId;
        private Transaction Transaction;

        public TransactionDetailsForm(string transactionId)
        {
            InitializeComponent();
            TransactionId = transactionId;
        }

        private void TransactionDetailsForm_Load(object sender, EventArgs e)
        {
            Transaction = TransactionDao.Instance.Transactions.First(item => item.Id == TransactionId);
            TextBoxCustomerName.Text = Transaction.CustomerName;
            TextBoxTotalTransaction.Text = Transaction.Total.ToString();
            TextBoxTimestamp.Text = Transaction.Timestamp.ToString();

            DataGridViewTransactionDetails.DataSource = TransactionDao.Instance.ToTransactionDetailsDataTable(Transaction.Details);
        }
    }
}
