namespace POS
{
    partial class ProductCategoryForm
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
            DataGridViewProductCategory = new DataGridView();
            TextBoxName = new TextBox();
            LabelName = new Label();
            LabelDescription = new Label();
            TextBoxDescription = new TextBox();
            ButtonSubmit = new Button();
            ButtonCancelEdit = new Button();
            ((System.ComponentModel.ISupportInitialize)DataGridViewProductCategory).BeginInit();
            SuspendLayout();
            // 
            // DataGridViewProductCategory
            // 
            DataGridViewProductCategory.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DataGridViewProductCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewProductCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewProductCategory.Location = new Point(236, 9);
            DataGridViewProductCategory.Margin = new Padding(2);
            DataGridViewProductCategory.Name = "DataGridViewProductCategory";
            DataGridViewProductCategory.ReadOnly = true;
            DataGridViewProductCategory.RowHeadersWidth = 72;
            DataGridViewProductCategory.RowTemplate.Height = 45;
            DataGridViewProductCategory.Size = new Size(834, 478);
            DataGridViewProductCategory.TabIndex = 0;
            DataGridViewProductCategory.CellContentClick += DataGridViewProductCategory_CellContentClick;
            // 
            // TextBoxName
            // 
            TextBoxName.Location = new Point(9, 42);
            TextBoxName.Margin = new Padding(2);
            TextBoxName.Name = "TextBoxName";
            TextBoxName.Size = new Size(218, 32);
            TextBoxName.TabIndex = 1;
            // 
            // LabelName
            // 
            LabelName.AutoSize = true;
            LabelName.Location = new Point(9, 9);
            LabelName.Margin = new Padding(2, 0, 2, 0);
            LabelName.Name = "LabelName";
            LabelName.Size = new Size(64, 30);
            LabelName.TabIndex = 2;
            LabelName.Text = "Name";
            // 
            // LabelDescription
            // 
            LabelDescription.AutoSize = true;
            LabelDescription.Location = new Point(9, 91);
            LabelDescription.Margin = new Padding(2, 0, 2, 0);
            LabelDescription.Name = "LabelDescription";
            LabelDescription.Size = new Size(115, 30);
            LabelDescription.TabIndex = 3;
            LabelDescription.Text = "Description";
            // 
            // TextBoxDescription
            // 
            TextBoxDescription.Location = new Point(9, 127);
            TextBoxDescription.Margin = new Padding(2);
            TextBoxDescription.Multiline = true;
            TextBoxDescription.Name = "TextBoxDescription";
            TextBoxDescription.Size = new Size(218, 83);
            TextBoxDescription.TabIndex = 4;
            // 
            // ButtonSubmit
            // 
            ButtonSubmit.Location = new Point(9, 229);
            ButtonSubmit.Margin = new Padding(2);
            ButtonSubmit.Name = "ButtonSubmit";
            ButtonSubmit.Size = new Size(216, 46);
            ButtonSubmit.TabIndex = 5;
            ButtonSubmit.Text = "Create";
            ButtonSubmit.UseVisualStyleBackColor = true;
            ButtonSubmit.Click += ButtonSubmit_Click;
            // 
            // ButtonCancelEdit
            // 
            ButtonCancelEdit.Location = new Point(9, 290);
            ButtonCancelEdit.Margin = new Padding(2);
            ButtonCancelEdit.Name = "ButtonCancelEdit";
            ButtonCancelEdit.Size = new Size(216, 46);
            ButtonCancelEdit.TabIndex = 6;
            ButtonCancelEdit.Text = "Cancel Edit";
            ButtonCancelEdit.UseVisualStyleBackColor = true;
            ButtonCancelEdit.Visible = false;
            ButtonCancelEdit.Click += ButtonCancelEdit_Click;
            // 
            // ProductCategoryForm
            // 
            AutoScaleDimensions = new SizeF(11F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1080, 504);
            Controls.Add(ButtonCancelEdit);
            Controls.Add(ButtonSubmit);
            Controls.Add(TextBoxDescription);
            Controls.Add(LabelDescription);
            Controls.Add(LabelName);
            Controls.Add(TextBoxName);
            Controls.Add(DataGridViewProductCategory);
            Font = new Font("Gill Sans MT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "ProductCategoryForm";
            Text = "Product Category Menu";
            Load += ProductCategoryForm_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridViewProductCategory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DataGridViewProductCategory;
        private TextBox TextBoxName;
        private Label LabelName;
        private Label LabelDescription;
        private TextBox TextBoxDescription;
        private Button ButtonSubmit;
        private Button ButtonCancelEdit;
    }
}