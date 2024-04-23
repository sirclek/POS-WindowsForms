namespace POS
{
    partial class CreateTransactionForm
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
            DataGridViewProduct = new DataGridView();
            LabelProduct = new Label();
            TextBoxProduct = new TextBox();
            LabelQuantity = new Label();
            ButtonAddToTransaction = new Button();
            DataGridViewTransactionDetails = new DataGridView();
            LabelTransactionList = new Label();
            ButtonSaveTransaction = new Button();
            LabelTotal = new Label();
            TextBoxTotal = new TextBox();
            NumericInputQuantity = new NumericUpDown();
            label1 = new Label();
            TextBoxCustomerName = new TextBox();
            ButtonReset = new Button();
            ((System.ComponentModel.ISupportInitialize)DataGridViewProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataGridViewTransactionDetails).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumericInputQuantity).BeginInit();
            SuspendLayout();
            // 
            // DataGridViewProduct
            // 
            DataGridViewProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewProduct.Location = new Point(9, 9);
            DataGridViewProduct.Margin = new Padding(2);
            DataGridViewProduct.Name = "DataGridViewProduct";
            DataGridViewProduct.ReadOnly = true;
            DataGridViewProduct.RowHeadersWidth = 72;
            DataGridViewProduct.RowTemplate.Height = 45;
            DataGridViewProduct.Size = new Size(792, 232);
            DataGridViewProduct.TabIndex = 0;
            DataGridViewProduct.CellClick += DataGridViewProduct_CellClick;
            // 
            // LabelProduct
            // 
            LabelProduct.AutoSize = true;
            LabelProduct.Location = new Point(815, 9);
            LabelProduct.Margin = new Padding(2, 0, 2, 0);
            LabelProduct.Name = "LabelProduct";
            LabelProduct.Size = new Size(82, 30);
            LabelProduct.TabIndex = 1;
            LabelProduct.Text = "Product";
            // 
            // TextBoxProduct
            // 
            TextBoxProduct.Location = new Point(813, 43);
            TextBoxProduct.Margin = new Padding(2);
            TextBoxProduct.Name = "TextBoxProduct";
            TextBoxProduct.Size = new Size(234, 32);
            TextBoxProduct.TabIndex = 2;
            TextBoxProduct.TextChanged += TextBoxProduct_TextChanged;
            // 
            // LabelQuantity
            // 
            LabelQuantity.AutoSize = true;
            LabelQuantity.Location = new Point(816, 104);
            LabelQuantity.Margin = new Padding(2, 0, 2, 0);
            LabelQuantity.Name = "LabelQuantity";
            LabelQuantity.Size = new Size(89, 30);
            LabelQuantity.TabIndex = 3;
            LabelQuantity.Text = "Quantity";
            // 
            // ButtonAddToTransaction
            // 
            ButtonAddToTransaction.Location = new Point(816, 202);
            ButtonAddToTransaction.Margin = new Padding(2);
            ButtonAddToTransaction.Name = "ButtonAddToTransaction";
            ButtonAddToTransaction.Size = new Size(233, 39);
            ButtonAddToTransaction.TabIndex = 5;
            ButtonAddToTransaction.Text = "Add to Transaction";
            ButtonAddToTransaction.UseVisualStyleBackColor = true;
            ButtonAddToTransaction.Click += ButtonAddToTransaction_Click;
            // 
            // DataGridViewTransactionDetails
            // 
            DataGridViewTransactionDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewTransactionDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewTransactionDetails.Location = new Point(9, 321);
            DataGridViewTransactionDetails.Margin = new Padding(2);
            DataGridViewTransactionDetails.Name = "DataGridViewTransactionDetails";
            DataGridViewTransactionDetails.ReadOnly = true;
            DataGridViewTransactionDetails.RowHeadersWidth = 72;
            DataGridViewTransactionDetails.RowTemplate.Height = 45;
            DataGridViewTransactionDetails.Size = new Size(792, 354);
            DataGridViewTransactionDetails.TabIndex = 6;
            // 
            // LabelTransactionList
            // 
            LabelTransactionList.AutoSize = true;
            LabelTransactionList.Location = new Point(10, 283);
            LabelTransactionList.Margin = new Padding(2, 0, 2, 0);
            LabelTransactionList.Name = "LabelTransactionList";
            LabelTransactionList.Size = new Size(151, 30);
            LabelTransactionList.TabIndex = 7;
            LabelTransactionList.Text = "Transaction List";
            // 
            // ButtonSaveTransaction
            // 
            ButtonSaveTransaction.Location = new Point(813, 508);
            ButtonSaveTransaction.Margin = new Padding(2);
            ButtonSaveTransaction.Name = "ButtonSaveTransaction";
            ButtonSaveTransaction.Size = new Size(233, 38);
            ButtonSaveTransaction.TabIndex = 8;
            ButtonSaveTransaction.Text = "Save Transaction";
            ButtonSaveTransaction.UseVisualStyleBackColor = true;
            ButtonSaveTransaction.Click += ButtonSaveTransaction_Click;
            // 
            // LabelTotal
            // 
            LabelTotal.AutoSize = true;
            LabelTotal.Location = new Point(814, 317);
            LabelTotal.Margin = new Padding(2, 0, 2, 0);
            LabelTotal.Name = "LabelTotal";
            LabelTotal.Size = new Size(59, 30);
            LabelTotal.TabIndex = 9;
            LabelTotal.Text = "Total";
            // 
            // TextBoxTotal
            // 
            TextBoxTotal.Location = new Point(815, 351);
            TextBoxTotal.Margin = new Padding(2);
            TextBoxTotal.Name = "TextBoxTotal";
            TextBoxTotal.ReadOnly = true;
            TextBoxTotal.Size = new Size(234, 32);
            TextBoxTotal.TabIndex = 10;
            // 
            // NumericInputQuantity
            // 
            NumericInputQuantity.Location = new Point(816, 136);
            NumericInputQuantity.Margin = new Padding(2);
            NumericInputQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NumericInputQuantity.Name = "NumericInputQuantity";
            NumericInputQuantity.Size = new Size(233, 32);
            NumericInputQuantity.TabIndex = 11;
            NumericInputQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(815, 403);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(157, 30);
            label1.TabIndex = 12;
            label1.Text = "Customer Name";
            // 
            // TextBoxCustomerName
            // 
            TextBoxCustomerName.Location = new Point(815, 436);
            TextBoxCustomerName.Margin = new Padding(2);
            TextBoxCustomerName.Name = "TextBoxCustomerName";
            TextBoxCustomerName.Size = new Size(234, 32);
            TextBoxCustomerName.TabIndex = 13;
            // 
            // ButtonReset
            // 
            ButtonReset.Location = new Point(813, 561);
            ButtonReset.Margin = new Padding(2);
            ButtonReset.Name = "ButtonReset";
            ButtonReset.Size = new Size(233, 38);
            ButtonReset.TabIndex = 14;
            ButtonReset.Text = "Reset Transaction";
            ButtonReset.UseVisualStyleBackColor = true;
            ButtonReset.Click += ButtonReset_Click;
            // 
            // CreateTransactionForm
            // 
            AutoScaleDimensions = new SizeF(11F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1057, 686);
            Controls.Add(ButtonReset);
            Controls.Add(TextBoxCustomerName);
            Controls.Add(label1);
            Controls.Add(NumericInputQuantity);
            Controls.Add(TextBoxTotal);
            Controls.Add(LabelTotal);
            Controls.Add(ButtonSaveTransaction);
            Controls.Add(LabelTransactionList);
            Controls.Add(DataGridViewTransactionDetails);
            Controls.Add(ButtonAddToTransaction);
            Controls.Add(LabelQuantity);
            Controls.Add(TextBoxProduct);
            Controls.Add(LabelProduct);
            Controls.Add(DataGridViewProduct);
            Font = new Font("Gill Sans MT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "CreateTransactionForm";
            Text = "Create Transaction Menu";
            Load += TransactionForm_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridViewProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGridViewTransactionDetails).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumericInputQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DataGridViewProduct;
        private Label LabelProduct;
        private TextBox TextBoxProduct;
        private Label LabelQuantity;
        private Button ButtonAddToTransaction;
        private DataGridView DataGridViewTransactionDetails;
        private Label LabelTransactionList;
        private Button ButtonSaveTransaction;
        private Label LabelTotal;
        private TextBox TextBoxTotal;
        private NumericUpDown NumericInputQuantity;
        private Label label1;
        private TextBox TextBoxCustomerName;
        private Button ButtonReset;
    }
}