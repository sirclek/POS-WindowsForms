namespace POS
{
    partial class LoginForm
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
            TextBoxUsername = new TextBox();
            LabelUsername = new Label();
            TextBoxPassword = new TextBox();
            LabelPassword = new Label();
            ButtonLogin = new Button();
            SuspendLayout();
            // 
            // TextBoxUsername
            // 
            TextBoxUsername.Font = new Font("Gill Sans MT", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxUsername.Location = new Point(217, 79);
            TextBoxUsername.Margin = new Padding(4);
            TextBoxUsername.Name = "TextBoxUsername";
            TextBoxUsername.Size = new Size(293, 34);
            TextBoxUsername.TabIndex = 0;
            // 
            // LabelUsername
            // 
            LabelUsername.AutoSize = true;
            LabelUsername.Font = new Font("Gill Sans MT", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            LabelUsername.Location = new Point(217, 46);
            LabelUsername.Name = "LabelUsername";
            LabelUsername.Size = new Size(116, 34);
            LabelUsername.TabIndex = 1;
            LabelUsername.Text = "Username";
            // 
            // TextBoxPassword
            // 
            TextBoxPassword.Font = new Font("Gill Sans MT", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxPassword.Location = new Point(217, 159);
            TextBoxPassword.Name = "TextBoxPassword";
            TextBoxPassword.Size = new Size(293, 34);
            TextBoxPassword.TabIndex = 2;
            // 
            // LabelPassword
            // 
            LabelPassword.AutoSize = true;
            LabelPassword.Font = new Font("Gill Sans MT", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            LabelPassword.Location = new Point(217, 126);
            LabelPassword.Name = "LabelPassword";
            LabelPassword.Size = new Size(107, 34);
            LabelPassword.TabIndex = 3;
            LabelPassword.Text = "Password";
            // 
            // ButtonLogin
            // 
            ButtonLogin.Font = new Font("Gill Sans MT", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonLogin.Location = new Point(217, 232);
            ButtonLogin.Name = "ButtonLogin";
            ButtonLogin.Size = new Size(293, 99);
            ButtonLogin.TabIndex = 4;
            ButtonLogin.Text = "Login";
            ButtonLogin.UseVisualStyleBackColor = true;
            ButtonLogin.Click += ButtonLogin_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(15F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(715, 408);
            Controls.Add(ButtonLogin);
            Controls.Add(LabelPassword);
            Controls.Add(TextBoxPassword);
            Controls.Add(LabelUsername);
            Controls.Add(TextBoxUsername);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "LoginForm";
            Text = "Login Form";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextBoxUsername;
        private Label LabelUsername;
        private TextBox TextBoxPassword;
        private Label LabelPassword;
        private Button ButtonLogin;
    }
}