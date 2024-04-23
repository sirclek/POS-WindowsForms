namespace POS
{
    partial class TransactionDetailsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewTransactionDetails = new DataGridView();
            LabelCustomerName = new Label();
            LabelTimestamp = new Label();
            LabelTotalTransaction = new Label();
            TextBoxCustomerName = new TextBox();
            TextBoxTimestamp = new TextBox();
            TextBoxTotalTransaction = new TextBox();
            ((System.ComponentModel.ISupportInitialize)DataGridViewTransactionDetails).BeginInit();
            SuspendLayout();
            // 
            // DataGridViewTransactionDetails
            // 
            DataGridViewTransactionDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewTransactionDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewTransactionDetails.Location = new Point(38, 169);
            DataGridViewTransactionDetails.Margin = new Padding(2);
            DataGridViewTransactionDetails.Name = "DataGridViewTransactionDetails";
            DataGridViewTransactionDetails.RowHeadersWidth = 72;
            DataGridViewTransactionDetails.RowTemplate.Height = 45;
            DataGridViewTransactionDetails.Size = new Size(756, 388);
            DataGridViewTransactionDetails.TabIndex = 0;
            // 
            // LabelCustomerName
            // 
            LabelCustomerName.AutoSize = true;
            LabelCustomerName.Location = new Point(38, 14);
            LabelCustomerName.Margin = new Padding(2, 0, 2, 0);
            LabelCustomerName.Name = "LabelCustomerName";
            LabelCustomerName.Size = new Size(157, 30);
            LabelCustomerName.TabIndex = 1;
            LabelCustomerName.Text = "Customer Name";
            // 
            // LabelTimestamp
            // 
            LabelTimestamp.AutoSize = true;
            LabelTimestamp.Location = new Point(37, 60);
            LabelTimestamp.Margin = new Padding(2, 0, 2, 0);
            LabelTimestamp.Name = "LabelTimestamp";
            LabelTimestamp.Size = new Size(108, 30);
            LabelTimestamp.TabIndex = 2;
            LabelTimestamp.Text = "Timestamp";
            // 
            // LabelTotalTransaction
            // 
            LabelTotalTransaction.AutoSize = true;
            LabelTotalTransaction.Location = new Point(34, 106);
            LabelTotalTransaction.Margin = new Padding(2, 0, 2, 0);
            LabelTotalTransaction.Name = "LabelTotalTransaction";
            LabelTotalTransaction.Size = new Size(167, 30);
            LabelTotalTransaction.TabIndex = 3;
            LabelTotalTransaction.Text = "Total Transaction";
            // 
            // TextBoxCustomerName
            // 
            TextBoxCustomerName.Location = new Point(205, 9);
            TextBoxCustomerName.Margin = new Padding(2);
            TextBoxCustomerName.Name = "TextBoxCustomerName";
            TextBoxCustomerName.ReadOnly = true;
            TextBoxCustomerName.Size = new Size(253, 32);
            TextBoxCustomerName.TabIndex = 5;
            // 
            // TextBoxTimestamp
            // 
            TextBoxTimestamp.Location = new Point(205, 58);
            TextBoxTimestamp.Margin = new Padding(2);
            TextBoxTimestamp.Name = "TextBoxTimestamp";
            TextBoxTimestamp.ReadOnly = true;
            TextBoxTimestamp.Size = new Size(253, 32);
            TextBoxTimestamp.TabIndex = 6;
            // 
            // TextBoxTotalTransaction
            // 
            TextBoxTotalTransaction.Location = new Point(205, 106);
            TextBoxTotalTransaction.Margin = new Padding(2);
            TextBoxTotalTransaction.Name = "TextBoxTotalTransaction";
            TextBoxTotalTransaction.ReadOnly = true;
            TextBoxTotalTransaction.Size = new Size(253, 32);
            TextBoxTotalTransaction.TabIndex = 7;
            // 
            // TransactionDetailsForm
            // 
            AutoScaleDimensions = new SizeF(11F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(833, 580);
            Controls.Add(TextBoxTotalTransaction);
            Controls.Add(TextBoxTimestamp);
            Controls.Add(TextBoxCustomerName);
            Controls.Add(LabelTotalTransaction);
            Controls.Add(LabelTimestamp);
            Controls.Add(LabelCustomerName);
            Controls.Add(DataGridViewTransactionDetails);
            Font = new Font("Gill Sans MT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "TransactionDetailsForm";
            Text = "Transaction Details";
            Load += TransactionDetailsForm_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridViewTransactionDetails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DataGridViewTransactionDetails;
        private Label LabelCustomerName;
        private Label LabelTimestamp;
        private Label LabelTotalTransaction;
        private TextBox TextBoxCustomerName;
        private TextBox TextBoxTimestamp;
        private TextBox TextBoxTotalTransaction;
    }
}