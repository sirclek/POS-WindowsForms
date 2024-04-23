namespace POS
{
    partial class ProductControlForm
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
            LabelName = new Label();
            TextBoxName = new TextBox();
            LabelPrice = new Label();
            LabelStock = new Label();
            ComboBoxCategory = new ComboBox();
            LabelCategory = new Label();
            ButtonSubmit = new Button();
            DataGridViewProduct = new DataGridView();
            CancelEditButton = new Button();
            AdminPanel = new Panel();
            NumericUpDownStock = new NumericUpDown();
            NumericUpDownPrice = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)DataGridViewProduct).BeginInit();
            AdminPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumericUpDownStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumericUpDownPrice).BeginInit();
            SuspendLayout();
            // 
            // LabelName
            // 
            LabelName.AutoSize = true;
            LabelName.Location = new Point(5, 11);
            LabelName.Margin = new Padding(2, 0, 2, 0);
            LabelName.Name = "LabelName";
            LabelName.Size = new Size(64, 30);
            LabelName.TabIndex = 0;
            LabelName.Text = "Name";
            // 
            // TextBoxName
            // 
            TextBoxName.Location = new Point(5, 44);
            TextBoxName.Margin = new Padding(2);
            TextBoxName.Name = "TextBoxName";
            TextBoxName.Size = new Size(213, 32);
            TextBoxName.TabIndex = 1;
            // 
            // LabelPrice
            // 
            LabelPrice.AutoSize = true;
            LabelPrice.Location = new Point(5, 80);
            LabelPrice.Margin = new Padding(2, 0, 2, 0);
            LabelPrice.Name = "LabelPrice";
            LabelPrice.Size = new Size(56, 30);
            LabelPrice.TabIndex = 2;
            LabelPrice.Text = "Price";
            // 
            // LabelStock
            // 
            LabelStock.AutoSize = true;
            LabelStock.Location = new Point(5, 148);
            LabelStock.Margin = new Padding(2, 0, 2, 0);
            LabelStock.Name = "LabelStock";
            LabelStock.Size = new Size(61, 30);
            LabelStock.TabIndex = 4;
            LabelStock.Text = "Stock";
            // 
            // ComboBoxCategory
            // 
            ComboBoxCategory.AutoCompleteMode = AutoCompleteMode.Suggest;
            ComboBoxCategory.FormattingEnabled = true;
            ComboBoxCategory.Location = new Point(5, 247);
            ComboBoxCategory.Margin = new Padding(2);
            ComboBoxCategory.Name = "ComboBoxCategory";
            ComboBoxCategory.Size = new Size(213, 38);
            ComboBoxCategory.TabIndex = 6;
            // 
            // LabelCategory
            // 
            LabelCategory.AutoSize = true;
            LabelCategory.Location = new Point(5, 214);
            LabelCategory.Margin = new Padding(2, 0, 2, 0);
            LabelCategory.Name = "LabelCategory";
            LabelCategory.Size = new Size(92, 30);
            LabelCategory.TabIndex = 7;
            LabelCategory.Text = "Category";
            // 
            // ButtonSubmit
            // 
            ButtonSubmit.Location = new Point(5, 311);
            ButtonSubmit.Margin = new Padding(2);
            ButtonSubmit.Name = "ButtonSubmit";
            ButtonSubmit.Size = new Size(212, 39);
            ButtonSubmit.TabIndex = 8;
            ButtonSubmit.Text = "Create";
            ButtonSubmit.UseVisualStyleBackColor = true;
            ButtonSubmit.Click += ButtonSubmit_Click;
            // 
            // DataGridViewProduct
            // 
            DataGridViewProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewProduct.Location = new Point(236, 7);
            DataGridViewProduct.Margin = new Padding(2);
            DataGridViewProduct.Name = "DataGridViewProduct";
            DataGridViewProduct.ReadOnly = true;
            DataGridViewProduct.RowHeadersWidth = 72;
            DataGridViewProduct.RowTemplate.Height = 45;
            DataGridViewProduct.Size = new Size(843, 472);
            DataGridViewProduct.TabIndex = 9;
            DataGridViewProduct.CellContentClick += DataGridViewProduct_CellContentClick_1;
            // 
            // CancelEditButton
            // 
            CancelEditButton.Location = new Point(5, 362);
            CancelEditButton.Margin = new Padding(2);
            CancelEditButton.Name = "CancelEditButton";
            CancelEditButton.Size = new Size(212, 39);
            CancelEditButton.TabIndex = 10;
            CancelEditButton.Text = "Cancel Edit";
            CancelEditButton.UseVisualStyleBackColor = true;
            CancelEditButton.Visible = false;
            CancelEditButton.Click += CancelEditButton_Click;
            // 
            // AdminPanel
            // 
            AdminPanel.Controls.Add(NumericUpDownPrice);
            AdminPanel.Controls.Add(NumericUpDownStock);
            AdminPanel.Controls.Add(TextBoxName);
            AdminPanel.Controls.Add(LabelName);
            AdminPanel.Controls.Add(CancelEditButton);
            AdminPanel.Controls.Add(LabelPrice);
            AdminPanel.Controls.Add(ButtonSubmit);
            AdminPanel.Controls.Add(LabelStock);
            AdminPanel.Controls.Add(LabelCategory);
            AdminPanel.Controls.Add(ComboBoxCategory);
            AdminPanel.Location = new Point(9, 9);
            AdminPanel.Margin = new Padding(2);
            AdminPanel.Name = "AdminPanel";
            AdminPanel.Size = new Size(224, 470);
            AdminPanel.TabIndex = 11;
            // 
            // NumericUpDownStock
            // 
            NumericUpDownStock.Location = new Point(5, 181);
            NumericUpDownStock.Name = "NumericUpDownStock";
            NumericUpDownStock.Size = new Size(212, 32);
            NumericUpDownStock.TabIndex = 11;
            // 
            // NumericUpDownPrice
            // 
            NumericUpDownPrice.Location = new Point(5, 113);
            NumericUpDownPrice.Name = "NumericUpDownPrice";
            NumericUpDownPrice.Size = new Size(213, 32);
            NumericUpDownPrice.TabIndex = 12;
            // 
            // ProductControlForm
            // 
            AutoScaleDimensions = new SizeF(11F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1098, 497);
            Controls.Add(AdminPanel);
            Controls.Add(DataGridViewProduct);
            Font = new Font("Gill Sans MT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "ProductControlForm";
            Text = "Product Menu";
            Load += ProductForm_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridViewProduct).EndInit();
            AdminPanel.ResumeLayout(false);
            AdminPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumericUpDownStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumericUpDownPrice).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label LabelName;
        private TextBox TextBoxName;
        private Label LabelPrice;
        private Label LabelStock;
        private ComboBox ComboBoxCategory;
        private Label LabelCategory;
        private Button ButtonSubmit;
        private DataGridView DataGridViewProduct;
        private Button CancelEditButton;
        private Panel AdminPanel;
        private NumericUpDown NumericUpDownStock;
        private NumericUpDown NumericUpDownPrice;
    }
}