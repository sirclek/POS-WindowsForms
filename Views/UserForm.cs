using POS;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace POS
{
    public partial class UserForm : Form
    {
        private int EditIndex = -1;
        DataTable table = new DataTable();
        private string filePath = "ProductCategoryTable.txt";

        public UserForm()
        {
            InitializeComponent();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            RefreshTable();

            //ComboBox population 
            cmbBoxRole.Items.Add("admin");
            cmbBoxRole.Items.Add("cashier");
        }

        public void RefreshTable()
        {

            EmployeeDao employeeDatabase = new EmployeeDao();
            DataTable dataTable = employeeDatabase.ToDataTable();
            dataTable.Columns.Add("Action Update");
            dataTable.Columns.Add("Action Delete");

            foreach (DataRow row in dataTable.Rows)
            {
                row["Action Update"] = "Update";
                row["Action Delete"] = "Delete";
            }

            dataGridView1.DataSource = dataTable;
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            if (EditIndex == -1)
            {
                if (textBoxName.Text.Length == 0 || textBoxEmail.Text.Length == 0 || textBoxUsername.Text.Length == 0 || textBoxPassword.Text.Length == 0
                    || cmbBoxRole.SelectedIndex == -1)
                {
                    MessageBox.Show("Please fill out the input form!");
                }

                else
                {
                    EmployeeDao.Instance.employees.Add(new Employee(Guid.NewGuid().ToString(), textBoxName.Text, textBoxEmail.Text, textBoxUsername.Text, textBoxPassword.Text, cmbBoxRole.SelectedItem.ToString()));
                    EmployeeDao.Instance.SaveDataToFile();
                    textBoxName.Text = "";
                    textBoxEmail.Text = "";
                    textBoxUsername.Text = "";
                    textBoxPassword.Text = "";
                    cmbBoxRole.SelectedIndex = -1;
                    RefreshTable();
                }
            }

            else
            {
                EmployeeDao.Instance.employees[EditIndex].Name = textBoxName.Text;
                EmployeeDao.Instance.employees[EditIndex].Email = textBoxEmail.Text;
                EmployeeDao.Instance.employees[EditIndex].Username = textBoxUsername.Text;
                EmployeeDao.Instance.employees[EditIndex].Password = textBoxPassword.Text;
                EmployeeDao.Instance.employees[EditIndex].Role = cmbBoxRole.Text;

                EmployeeDao.Instance.SaveDataToFile();
                textBoxName.Text = "";
                textBoxEmail.Text = "";
                textBoxUsername.Text = "";
                textBoxPassword.Text = "";
                cmbBoxRole.SelectedIndex = -1;
                RefreshTable();

                EditIndex = -1;
                createButton.Text = "Create";
                button1.Hide();

            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string cellValue = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                if (cellValue == "Update")
                {
                    textBoxName.Text = dataGridView1.Rows[e.RowIndex].Cells[dataGridView1.Columns["Name"].Index].Value.ToString();
                    textBoxEmail.Text = dataGridView1.Rows[e.RowIndex].Cells[dataGridView1.Columns["Email"].Index].Value.ToString();
                    textBoxUsername.Text = dataGridView1.Rows[e.RowIndex].Cells[dataGridView1.Columns["Username"].Index].Value.ToString();
                    textBoxPassword.Text = dataGridView1.Rows[e.RowIndex].Cells[dataGridView1.Columns["Password"].Index].Value.ToString();
                    cmbBoxRole.SelectedItem = dataGridView1.Rows[e.RowIndex].Cells[dataGridView1.Columns["Role"].Index].Value.ToString();

                    EditIndex = e.RowIndex;
                    createButton.Text = "Edit";
                    button1.Show();
                }

                else if (cellValue == "Delete")
                {
                    var result = MessageBox.Show("Do you want to delete this employee?", "Confirmation", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        EmployeeDao.Instance.employees.RemoveAt(e.RowIndex);
                        EmployeeDao.Instance.SaveDataToFile();
                        this.RefreshTable();
                    }
                }
            }

        }

        private void UserForm_Load_1(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditIndex = -1;
            createButton.Text = "Create";
            textBoxName.Text = "";
            textBoxEmail.Text = "";
            textBoxUsername.Text = "";
            textBoxPassword.Text = "";
            cmbBoxRole.SelectedIndex = -1;

            button1.Hide();
        }

        private void labelUsername_Click(object sender, EventArgs e)
        {

        }

        private void labelPassword_Click(object sender, EventArgs e)
        {

        }

        private void labelRole_Click(object sender, EventArgs e)
        {

        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }
    }
}