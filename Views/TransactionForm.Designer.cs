namespace POS
{
    partial class TransactionForm
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
            ButtonCreateTransaction = new Button();
            DataGridViewTransaction = new DataGridView();
            LabelTransactionList = new Label();
            label1 = new Label();
            TextBoxName = new TextBox();
            ButtonSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)DataGridViewTransaction).BeginInit();
            SuspendLayout();
            // 
            // ButtonCreateTransaction
            // 
            ButtonCreateTransaction.Location = new Point(999, 68);
            ButtonCreateTransaction.Name = "ButtonCreateTransaction";
            ButtonCreateTransaction.Size = new Size(195, 53);
            ButtonCreateTransaction.TabIndex = 0;
            ButtonCreateTransaction.Text = "Create Transaction";
            ButtonCreateTransaction.UseVisualStyleBackColor = true;
            ButtonCreateTransaction.Click += ButtonCreateTransaction_Click;
            // 
            // DataGridViewTransaction
            // 
            DataGridViewTransaction.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewTransaction.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewTransaction.Location = new Point(12, 132);
            DataGridViewTransaction.Name = "DataGridViewTransaction";
            DataGridViewTransaction.ReadOnly = true;
            DataGridViewTransaction.RowHeadersWidth = 72;
            DataGridViewTransaction.RowTemplate.Height = 45;
            DataGridViewTransaction.Size = new Size(1182, 502);
            DataGridViewTransaction.TabIndex = 1;
            DataGridViewTransaction.CellDoubleClick += DataGridViewTransaction_CellDoubleClick;
            // 
            // LabelTransactionList
            // 
            LabelTransactionList.AutoSize = true;
            LabelTransactionList.Location = new Point(12, 20);
            LabelTransactionList.Name = "LabelTransactionList";
            LabelTransactionList.Size = new Size(198, 39);
            LabelTransactionList.TabIndex = 2;
            LabelTransactionList.Text = "Transaction List";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 83);
            label1.Name = "label1";
            label1.Size = new Size(255, 32);
            label1.TabIndex = 3;
            label1.Text = "Enter Customer Name:";
            // 
            // TextBoxName
            // 
            TextBoxName.Location = new Point(301, 70);
            TextBoxName.Name = "TextBoxName";
            TextBoxName.Size = new Size(236, 40);
            TextBoxName.TabIndex = 4;
            // 
            // ButtonSearch
            // 
            ButtonSearch.Location = new Point(555, 70);
            ButtonSearch.Name = "ButtonSearch";
            ButtonSearch.Size = new Size(135, 51);
            ButtonSearch.TabIndex = 5;
            ButtonSearch.Text = "Search";
            ButtonSearch.UseVisualStyleBackColor = true;
            ButtonSearch.Click += ButtonSearch_Click;
            // 
            // TransactionForm
            // 
            AutoScaleDimensions = new SizeF(15F, 39F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1206, 647);
            Controls.Add(ButtonSearch);
            Controls.Add(TextBoxName);
            Controls.Add(label1);
            Controls.Add(LabelTransactionList);
            Controls.Add(DataGridViewTransaction);
            Controls.Add(ButtonCreateTransaction);
            Font = new Font("Gill Sans MT", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "TransactionForm";
            Text = "Transaction List Menu";
            Activated += TransactionForm_Activated;
            Load += TransactionForm_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridViewTransaction).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonCreateTransaction;
        private DataGridView DataGridViewTransaction;
        private Label LabelTransactionList;
        private Label label1;
        private TextBox TextBoxName;
        private Button ButtonSearch;
    }
}