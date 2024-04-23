using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using POS;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace POS
{
    public class EmployeeDao
    {
        //Singleton Data Access Object Instance
        //Restricts to only one instance of EmployeeDao
        //used as an object to access the datastore files
        private static EmployeeDao instance;
       
        //collection for header rows in file interactions
        private List<string> header;
        public List<Employee> employees { get; set; }
        private string filePath = "EmployeeTable.txt";

        public EmployeeDao()
        {
            employees = new List<Employee>();
            LoadDataFromFile();
        }

        //Getter for the private static instance
        public static EmployeeDao Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new EmployeeDao();
                }

                return instance;
            }
        }

        public void LoadDataFromFile()
        {
            employees.Clear();

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    bool isHeader = true;

                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(';');
                        if (isHeader == true)
                        {
                            header = parts.ToList();
                            isHeader = false;
                            continue;
                        }

                        else if (parts.Length == 6 && isHeader == false)
                        {
                            Employee employee = new Employee(parts[0], parts[1], parts[2], parts[3], parts[4], parts[5]);
                            employees.Add(employee);
                        }
                    }
                }
            }

            catch (IOException e)
            {
                MessageBox.Show("An error occurred while reading the file: " + e.Message);
            }
        }

        public void SaveDataToFile()
        {
            StringBuilder fileContent = new StringBuilder();
            fileContent.AppendLine(string.Join(";", header));

            foreach (var employee in employees)
            {
                fileContent.AppendLine($"{employee.ID};{employee.Name};{employee.Email};{employee.Username};{employee.Password};{employee.Role}");
            }

            File.WriteAllText(filePath, fileContent.ToString());
        }

        public DataTable ToDataTable()
        {
            DataTable dt = new DataTable();
            // Add columns to the DataTable
            dt.Columns.Add("ID", typeof(string));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Email", typeof(string));
            dt.Columns.Add("Username", typeof(string));
            dt.Columns.Add("Password", typeof(string));
            dt.Columns.Add("Role", typeof(string));

            // Populate the DataTable with employee data
            foreach (var employee in employees)
            {
                dt.Rows.Add(employee.ID, employee.Name, employee.Email, employee.Username, employee.Password, employee.Role);
            }

            return dt;
        }

        public List<Employee> GetEmployees()
        {
            return employees;
        }
    }
}
