namespace POS
{
    partial class DashboardForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            LabelAuthenticatedEmployee = new Label();
            btnMenuTransaction = new Button();
            btnMenuUsers = new Button();
            btnMenuProduct = new Button();
            btnMenuProductCategory = new Button();
            ControlPanelMenu = new FlowLayoutPanel();
            lblProduct = new Label();
            btnProductCatalogue = new Button();
            lblUsers = new Label();
            lblTransactions = new Label();
            ButtonLogOut = new Button();
            ExitButton = new Button();
            LabelDate = new Label();
            DataGridViewProductSales = new DataGridView();
            ChartTopProductsBySales = new System.Windows.Forms.DataVisualization.Charting.Chart();
            DataGridViewProductFrequency = new DataGridView();
            ChartTopProductsByFrequency = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ButtonRefresh = new Button();
            DataGridViewCategorySales = new DataGridView();
            LabelTotalSales = new Label();
            ChartTopCategoriesBySales = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ControlPanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewProductSales).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ChartTopProductsBySales).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataGridViewProductFrequency).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ChartTopProductsByFrequency).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataGridViewCategorySales).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ChartTopCategoriesBySales).BeginInit();
            SuspendLayout();
            // 
            // LabelAuthenticatedEmployee
            // 
            LabelAuthenticatedEmployee.AutoSize = true;
            LabelAuthenticatedEmployee.Font = new Font("Gill Sans MT", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LabelAuthenticatedEmployee.Location = new Point(66, 35);
            LabelAuthenticatedEmployee.Margin = new Padding(4, 0, 4, 0);
            LabelAuthenticatedEmployee.Name = "LabelAuthenticatedEmployee";
            LabelAuthenticatedEmployee.Size = new Size(200, 39);
            LabelAuthenticatedEmployee.TabIndex = 0;
            LabelAuthenticatedEmployee.Text = "Hello, Employee";
            // 
            // btnMenuTransaction
            // 
            btnMenuTransaction.Font = new Font("Gill Sans MT", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            btnMenuTransaction.Location = new Point(3, 407);
            btnMenuTransaction.Margin = new Padding(3, 4, 3, 4);
            btnMenuTransaction.Name = "btnMenuTransaction";
            btnMenuTransaction.Size = new Size(235, 66);
            btnMenuTransaction.TabIndex = 4;
            btnMenuTransaction.Text = "Transactions";
            btnMenuTransaction.UseVisualStyleBackColor = true;
            btnMenuTransaction.Click += btnMenuTransaction_Click;
            // 
            // btnMenuUsers
            // 
            btnMenuUsers.Font = new Font("Gill Sans MT", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            btnMenuUsers.Location = new Point(3, 304);
            btnMenuUsers.Margin = new Padding(3, 4, 3, 4);
            btnMenuUsers.Name = "btnMenuUsers";
            btnMenuUsers.Size = new Size(235, 56);
            btnMenuUsers.TabIndex = 1;
            btnMenuUsers.Text = "Users Control";
            btnMenuUsers.UseVisualStyleBackColor = true;
            btnMenuUsers.Click += btnMenuUsers_Click;
            // 
            // btnMenuProduct
            // 
            btnMenuProduct.Font = new Font("Gill Sans MT", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            btnMenuProduct.Location = new Point(3, 191);
            btnMenuProduct.Margin = new Padding(3, 4, 3, 4);
            btnMenuProduct.Name = "btnMenuProduct";
            btnMenuProduct.Size = new Size(235, 66);
            btnMenuProduct.TabIndex = 3;
            btnMenuProduct.Text = "Product Control";
            btnMenuProduct.UseVisualStyleBackColor = true;
            btnMenuProduct.Click += btnMenuProduct_Click;
            // 
            // btnMenuProductCategory
            // 
            btnMenuProductCategory.Font = new Font("Gill Sans MT", 8.142858F, FontStyle.Regular, GraphicsUnit.Point);
            btnMenuProductCategory.Location = new Point(3, 43);
            btnMenuProductCategory.Margin = new Padding(3, 4, 3, 4);
            btnMenuProductCategory.Name = "btnMenuProductCategory";
            btnMenuProductCategory.Size = new Size(235, 66);
            btnMenuProductCategory.TabIndex = 2;
            btnMenuProductCategory.Text = "Product Category Control";
            btnMenuProductCategory.UseVisualStyleBackColor = true;
            btnMenuProductCategory.Click += btnMenuProductCategory_Click;
            // 
            // ControlPanelMenu
            // 
            ControlPanelMenu.Controls.Add(lblProduct);
            ControlPanelMenu.Controls.Add(btnMenuProductCategory);
            ControlPanelMenu.Controls.Add(btnProductCatalogue);
            ControlPanelMenu.Controls.Add(btnMenuProduct);
            ControlPanelMenu.Controls.Add(lblUsers);
            ControlPanelMenu.Controls.Add(btnMenuUsers);
            ControlPanelMenu.Controls.Add(lblTransactions);
            ControlPanelMenu.Controls.Add(btnMenuTransaction);
            ControlPanelMenu.Controls.Add(ButtonLogOut);
            ControlPanelMenu.Controls.Add(ExitButton);
            ControlPanelMenu.FlowDirection = FlowDirection.TopDown;
            ControlPanelMenu.Font = new Font("Gill Sans MT", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ControlPanelMenu.Location = new Point(57, 112);
            ControlPanelMenu.Margin = new Padding(3, 4, 3, 4);
            ControlPanelMenu.Name = "ControlPanelMenu";
            ControlPanelMenu.Size = new Size(248, 754);
            ControlPanelMenu.TabIndex = 3;
            // 
            // lblProduct
            // 
            lblProduct.AutoSize = true;
            lblProduct.Location = new Point(3, 0);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(106, 39);
            lblProduct.TabIndex = 7;
            lblProduct.Text = "Product";
            // 
            // btnProductCatalogue
            // 
            btnProductCatalogue.Font = new Font("Gill Sans MT", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            btnProductCatalogue.Location = new Point(3, 117);
            btnProductCatalogue.Margin = new Padding(3, 4, 3, 4);
            btnProductCatalogue.Name = "btnProductCatalogue";
            btnProductCatalogue.Size = new Size(235, 66);
            btnProductCatalogue.TabIndex = 6;
            btnProductCatalogue.Text = "Product Catalogue";
            btnProductCatalogue.UseVisualStyleBackColor = true;
            btnProductCatalogue.Click += btnProductCatalogue_Click;
            // 
            // lblUsers
            // 
            lblUsers.AutoSize = true;
            lblUsers.Location = new Point(3, 261);
            lblUsers.Name = "lblUsers";
            lblUsers.Size = new Size(83, 39);
            lblUsers.TabIndex = 8;
            lblUsers.Text = "Users";
            // 
            // lblTransactions
            // 
            lblTransactions.AutoSize = true;
            lblTransactions.Location = new Point(3, 364);
            lblTransactions.Name = "lblTransactions";
            lblTransactions.Size = new Size(161, 39);
            lblTransactions.TabIndex = 9;
            lblTransactions.Text = "Transactions";
            // 
            // ButtonLogOut
            // 
            ButtonLogOut.Font = new Font("Gill Sans MT", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonLogOut.Location = new Point(3, 481);
            ButtonLogOut.Margin = new Padding(3, 4, 3, 4);
            ButtonLogOut.Name = "ButtonLogOut";
            ButtonLogOut.Size = new Size(235, 66);
            ButtonLogOut.TabIndex = 10;
            ButtonLogOut.Text = "Log Out";
            ButtonLogOut.UseVisualStyleBackColor = true;
            ButtonLogOut.Click += ButtonLogOut_Click;
            // 
            // ExitButton
            // 
            ExitButton.Font = new Font("Gill Sans MT", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            ExitButton.Location = new Point(3, 555);
            ExitButton.Margin = new Padding(3, 4, 3, 4);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(235, 66);
            ExitButton.TabIndex = 5;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // LabelDate
            // 
            LabelDate.AutoSize = true;
            LabelDate.Font = new Font("Gill Sans MT", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LabelDate.Location = new Point(444, 37);
            LabelDate.Name = "LabelDate";
            LabelDate.Size = new Size(330, 39);
            LabelDate.TabIndex = 4;
            LabelDate.Text = "Today's date is (insert date)";
            // 
            // DataGridViewProductSales
            // 
            DataGridViewProductSales.AllowUserToAddRows = false;
            DataGridViewProductSales.AllowUserToDeleteRows = false;
            DataGridViewProductSales.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DataGridViewProductSales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewProductSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewProductSales.Location = new Point(365, 127);
            DataGridViewProductSales.Margin = new Padding(3, 4, 3, 4);
            DataGridViewProductSales.Name = "DataGridViewProductSales";
            DataGridViewProductSales.ReadOnly = true;
            DataGridViewProductSales.RowHeadersWidth = 72;
            DataGridViewProductSales.RowTemplate.Height = 45;
            DataGridViewProductSales.Size = new Size(514, 295);
            DataGridViewProductSales.TabIndex = 5;
            // 
            // ChartTopProductsBySales
            // 
            chartArea1.Name = "ChartArea1";
            ChartTopProductsBySales.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            ChartTopProductsBySales.Legends.Add(legend1);
            ChartTopProductsBySales.Location = new Point(365, 448);
            ChartTopProductsBySales.Margin = new Padding(3, 4, 3, 4);
            ChartTopProductsBySales.Name = "ChartTopProductsBySales";
            ChartTopProductsBySales.Size = new Size(514, 340);
            ChartTopProductsBySales.TabIndex = 10;
            ChartTopProductsBySales.Text = "chart1";
            // 
            // DataGridViewProductFrequency
            // 
            DataGridViewProductFrequency.AllowUserToAddRows = false;
            DataGridViewProductFrequency.AllowUserToDeleteRows = false;
            DataGridViewProductFrequency.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DataGridViewProductFrequency.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewProductFrequency.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewProductFrequency.Location = new Point(924, 127);
            DataGridViewProductFrequency.Margin = new Padding(3, 4, 3, 4);
            DataGridViewProductFrequency.Name = "DataGridViewProductFrequency";
            DataGridViewProductFrequency.ReadOnly = true;
            DataGridViewProductFrequency.RowHeadersWidth = 72;
            DataGridViewProductFrequency.RowTemplate.Height = 45;
            DataGridViewProductFrequency.Size = new Size(514, 295);
            DataGridViewProductFrequency.TabIndex = 11;
            // 
            // ChartTopProductsByFrequency
            // 
            chartArea2.Name = "ChartArea1";
            ChartTopProductsByFrequency.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            ChartTopProductsByFrequency.Legends.Add(legend2);
            ChartTopProductsByFrequency.Location = new Point(924, 448);
            ChartTopProductsByFrequency.Margin = new Padding(3, 4, 3, 4);
            ChartTopProductsByFrequency.Name = "ChartTopProductsByFrequency";
            ChartTopProductsByFrequency.Size = new Size(514, 340);
            ChartTopProductsByFrequency.TabIndex = 12;
            ChartTopProductsByFrequency.Text = "chart1";
            // 
            // ButtonRefresh
            // 
            ButtonRefresh.Font = new Font("Gill Sans MT", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonRefresh.Location = new Point(1790, 32);
            ButtonRefresh.Margin = new Padding(3, 4, 3, 4);
            ButtonRefresh.Name = "ButtonRefresh";
            ButtonRefresh.Size = new Size(185, 56);
            ButtonRefresh.TabIndex = 13;
            ButtonRefresh.Text = "Refresh Data";
            ButtonRefresh.TextAlign = ContentAlignment.TopCenter;
            ButtonRefresh.UseVisualStyleBackColor = true;
            ButtonRefresh.Click += ButtonRefresh_Click;
            // 
            // DataGridViewCategorySales
            // 
            DataGridViewCategorySales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewCategorySales.Location = new Point(1481, 127);
            DataGridViewCategorySales.Margin = new Padding(3, 4, 3, 4);
            DataGridViewCategorySales.Name = "DataGridViewCategorySales";
            DataGridViewCategorySales.ReadOnly = true;
            DataGridViewCategorySales.RowHeadersWidth = 72;
            DataGridViewCategorySales.RowTemplate.Height = 45;
            DataGridViewCategorySales.Size = new Size(514, 295);
            DataGridViewCategorySales.TabIndex = 14;
            // 
            // LabelTotalSales
            // 
            LabelTotalSales.AutoSize = true;
            LabelTotalSales.Font = new Font("Gill Sans MT", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LabelTotalSales.Location = new Point(1481, 44);
            LabelTotalSales.Name = "LabelTotalSales";
            LabelTotalSales.Size = new Size(147, 39);
            LabelTotalSales.TabIndex = 15;
            LabelTotalSales.Text = "(total sales)";
            // 
            // ChartTopCategoriesBySales
            // 
            chartArea3.Name = "ChartArea1";
            ChartTopCategoriesBySales.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            ChartTopCategoriesBySales.Legends.Add(legend3);
            ChartTopCategoriesBySales.Location = new Point(1481, 448);
            ChartTopCategoriesBySales.Margin = new Padding(3, 4, 3, 4);
            ChartTopCategoriesBySales.Name = "ChartTopCategoriesBySales";
            ChartTopCategoriesBySales.Size = new Size(514, 340);
            ChartTopCategoriesBySales.TabIndex = 16;
            ChartTopCategoriesBySales.Text = "chart1";
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(15F, 39F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(2018, 925);
            Controls.Add(ChartTopCategoriesBySales);
            Controls.Add(LabelTotalSales);
            Controls.Add(DataGridViewCategorySales);
            Controls.Add(ButtonRefresh);
            Controls.Add(ChartTopProductsByFrequency);
            Controls.Add(DataGridViewProductFrequency);
            Controls.Add(DataGridViewProductSales);
            Controls.Add(LabelDate);
            Controls.Add(ControlPanelMenu);
            Controls.Add(LabelAuthenticatedEmployee);
            Controls.Add(ChartTopProductsBySales);
            Font = new Font("Gill Sans MT", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "DashboardForm";
            Text = "Dashboard Form";
            Load += DashboardForm_Load;
            ControlPanelMenu.ResumeLayout(false);
            ControlPanelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewProductSales).EndInit();
            ((System.ComponentModel.ISupportInitialize)ChartTopProductsBySales).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGridViewProductFrequency).EndInit();
            ((System.ComponentModel.ISupportInitialize)ChartTopProductsByFrequency).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGridViewCategorySales).EndInit();
            ((System.ComponentModel.ISupportInitialize)ChartTopCategoriesBySales).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelAuthenticatedEmployee;
        private Button btnMenuTransaction;
        private Button btnMenuUsers;
        private Button btnMenuProduct;
        private Button btnMenuProductCategory;
        private FlowLayoutPanel ControlPanelMenu;
        private Button ExitButton;
        private Button btnProductCatalogue;
        private Label LabelDate;
        private DataGridView DataGridViewProductSales;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartTopProductsBySales;
        private DataGridView DataGridViewProductFrequency;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartTopProductsByFrequency;
        private Button ButtonRefresh;
        private DataGridView DataGridViewCategorySales;
        private Label LabelTotalSales;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartTopCategoriesBySales;
        private Label lblProduct;
        private Label lblUsers;
        private Label lblTransactions;
        private Button ButtonLogOut;
    }
}