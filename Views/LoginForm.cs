using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POS;

namespace POS
{
    public partial class LoginForm : Form
    {
        private AuthService AuthService;

        public LoginForm()
        {
            InitializeComponent();
            AuthService = new AuthService(EmployeeDao.Instance);
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            Employee authEmployee = AuthService.Login(TextBoxUsername.Text, TextBoxPassword.Text);


            if (authEmployee != null)
            {
                AuthenticatedEmployee.GetInstance().SetEmployee(authEmployee);
                MessageBox.Show("Login Successful!");

                DashboardForm dashboardForm = new DashboardForm();
                TextBoxUsername.Clear();
                TextBoxPassword.Clear();
                dashboardForm.ShowDialog();
            }

            else
            {
                MessageBox.Show("Wrong Credentials!");
                TextBoxUsername.Clear();
                TextBoxPassword.Clear();
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
