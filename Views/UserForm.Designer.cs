using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace POS
{
    partial class UserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer productComponents = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (productComponents != null))
            {
                productComponents.Dispose();
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
            dataGridView1 = new DataGridView();
            textBoxName = new TextBox();
            textBoxEmail = new TextBox();
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            createButton = new Button();
            labelName = new Label();
            labelEmail = new Label();
            labelUsername = new Label();
            labelPassword = new Label();
            labelRole = new Label();
            button1 = new Button();
            cmbBoxRole = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeight = 40;
            dataGridView1.Location = new Point(570, 64);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 72;
            dataGridView1.RowTemplate.Height = 45;
            dataGridView1.Size = new Size(1334, 1100);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(53, 82);
            textBoxName.Margin = new Padding(3, 4, 3, 4);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(402, 32);
            textBoxName.TabIndex = 7;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(53, 172);
            textBoxEmail.Margin = new Padding(3, 4, 3, 4);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(402, 32);
            textBoxEmail.TabIndex = 8;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(53, 266);
            textBoxUsername.Margin = new Padding(3, 4, 3, 4);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(402, 32);
            textBoxUsername.TabIndex = 9;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(53, 380);
            textBoxPassword.Margin = new Padding(3, 4, 3, 4);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(402, 32);
            textBoxPassword.TabIndex = 10;
            // 
            // createButton
            // 
            createButton.Location = new Point(119, 612);
            createButton.Margin = new Padding(3, 4, 3, 4);
            createButton.Name = "createButton";
            createButton.Size = new Size(253, 116);
            createButton.TabIndex = 12;
            createButton.Text = "Create";
            createButton.UseVisualStyleBackColor = true;
            createButton.Click += createButton_Click;
            // 
            // labelName
            // 
            labelName.Location = new Point(53, 44);
            labelName.Name = "labelName";
            labelName.Size = new Size(91, 34);
            labelName.TabIndex = 1;
            labelName.Text = "Name:";
            labelName.Click += labelName_Click;
            // 
            // labelEmail
            // 
            labelEmail.Location = new Point(53, 132);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(91, 36);
            labelEmail.TabIndex = 2;
            labelEmail.Text = "Email:";
            // 
            // labelUsername
            // 
            labelUsername.Location = new Point(53, 222);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(145, 40);
            labelUsername.TabIndex = 3;
            labelUsername.Text = "Username:";
            labelUsername.Click += labelUsername_Click;
            // 
            // labelPassword
            // 
            labelPassword.Location = new Point(53, 336);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(145, 33);
            labelPassword.TabIndex = 4;
            labelPassword.Text = "Password:";
            labelPassword.Click += labelPassword_Click;
            // 
            // labelRole
            // 
            labelRole.Location = new Point(53, 430);
            labelRole.Name = "labelRole";
            labelRole.Size = new Size(91, 42);
            labelRole.TabIndex = 5;
            labelRole.Text = "Role:";
            labelRole.Click += labelRole_Click;
            // 
            // button1
            // 
            button1.Location = new Point(119, 796);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(253, 124);
            button1.TabIndex = 0;
            button1.Text = "Cancel Edit ";
            button1.UseVisualStyleBackColor = true;
            button1.Visible = false;
            button1.Click += button1_Click;
            // 
            // cmbBoxRole
            // 
            cmbBoxRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBoxRole.FormattingEnabled = true;
            cmbBoxRole.Location = new Point(53, 475);
            cmbBoxRole.Name = "cmbBoxRole";
            cmbBoxRole.Size = new Size(402, 38);
            cmbBoxRole.TabIndex = 13;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(11F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1958, 1268);
            Controls.Add(cmbBoxRole);
            Controls.Add(button1);
            Controls.Add(labelName);
            Controls.Add(labelEmail);
            Controls.Add(labelUsername);
            Controls.Add(labelPassword);
            Controls.Add(labelRole);
            Controls.Add(dataGridView1);
            Controls.Add(textBoxName);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxUsername);
            Controls.Add(textBoxPassword);
            Controls.Add(createButton);
            Font = new Font("Gill Sans MT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UserForm";
            Text = "User Menu";
            Load += UserForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBoxID;
        private TextBox textBoxName;
        private TextBox textBoxEmail;
        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private Button createButton;
        private Button exitButton;
        private Label labelID;
        private Label labelName;
        private Label labelEmail;
        private Label labelUsername;
        private Label labelPassword;
        private Label labelRole;
        private Button button1;
        private ComboBox cmbBoxRole;
    }
}
