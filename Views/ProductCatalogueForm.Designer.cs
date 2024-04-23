namespace POS
{
    partial class ProductCatalogueForm
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
            DataGridViewCatalogue = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            TextBoxProductName = new TextBox();
            ComboBoxProductCategory = new ComboBox();
            ButtonFilterName = new Button();
            ButtonFilterCategory = new Button();
            ((System.ComponentModel.ISupportInitialize)DataGridViewCatalogue).BeginInit();
            SuspendLayout();
            // 
            // DataGridViewCatalogue
            // 
            DataGridViewCatalogue.AllowUserToAddRows = false;
            DataGridViewCatalogue.AllowUserToDeleteRows = false;
            DataGridViewCatalogue.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewCatalogue.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewCatalogue.Location = new Point(319, 8);
            DataGridViewCatalogue.Name = "DataGridViewCatalogue";
            DataGridViewCatalogue.ReadOnly = true;
            DataGridViewCatalogue.RowHeadersWidth = 72;
            DataGridViewCatalogue.RowTemplate.Height = 45;
            DataGridViewCatalogue.Size = new Size(1160, 667);
            DataGridViewCatalogue.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gill Sans MT", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(24, 21);
            label1.Name = "label1";
            label1.Size = new Size(127, 39);
            label1.TabIndex = 11;
            label1.Text = "Filter by";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gill Sans MT", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(22, 82);
            label2.Name = "label2";
            label2.Size = new Size(160, 34);
            label2.TabIndex = 12;
            label2.Text = "Product Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Gill Sans MT", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(22, 263);
            label3.Name = "label3";
            label3.Size = new Size(191, 34);
            label3.TabIndex = 13;
            label3.Text = "Product Category";
            // 
            // TextBoxProductName
            // 
            TextBoxProductName.Font = new Font("Gill Sans MT", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxProductName.Location = new Point(22, 118);
            TextBoxProductName.Name = "TextBoxProductName";
            TextBoxProductName.Size = new Size(277, 34);
            TextBoxProductName.TabIndex = 14;
            // 
            // ComboBoxProductCategory
            // 
            ComboBoxProductCategory.Font = new Font("Gill Sans MT", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            ComboBoxProductCategory.FormattingEnabled = true;
            ComboBoxProductCategory.Location = new Point(22, 298);
            ComboBoxProductCategory.Name = "ComboBoxProductCategory";
            ComboBoxProductCategory.Size = new Size(277, 41);
            ComboBoxProductCategory.TabIndex = 15;
            // 
            // ButtonFilterName
            // 
            ButtonFilterName.Font = new Font("Gill Sans MT", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonFilterName.Location = new Point(75, 174);
            ButtonFilterName.Name = "ButtonFilterName";
            ButtonFilterName.Size = new Size(171, 40);
            ButtonFilterName.TabIndex = 16;
            ButtonFilterName.Text = "Filter";
            ButtonFilterName.UseVisualStyleBackColor = true;
            ButtonFilterName.Click += ButtonFilter_Click;
            // 
            // ButtonFilterCategory
            // 
            ButtonFilterCategory.Font = new Font("Gill Sans MT", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonFilterCategory.Location = new Point(75, 359);
            ButtonFilterCategory.Name = "ButtonFilterCategory";
            ButtonFilterCategory.Size = new Size(171, 40);
            ButtonFilterCategory.TabIndex = 17;
            ButtonFilterCategory.Text = "Filter Category";
            ButtonFilterCategory.UseVisualStyleBackColor = true;
            ButtonFilterCategory.Click += ButtonFilterCategory_Click;
            // 
            // ProductCatalogueForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1491, 691);
            Controls.Add(ButtonFilterCategory);
            Controls.Add(ButtonFilterName);
            Controls.Add(ComboBoxProductCategory);
            Controls.Add(TextBoxProductName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(DataGridViewCatalogue);
            Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "ProductCatalogueForm";
            Text = "Product Catalogue Menu";
            Load += ProductCatalogueForm_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridViewCatalogue).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DataGridViewCatalogue;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox TextBoxProductName;
        private ComboBox ComboBoxProductCategory;
        private Button ButtonFilterName;
        private Button ButtonFilterCategory;
    }
}