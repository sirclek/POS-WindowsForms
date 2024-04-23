using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS;

namespace POS
{
    internal class AuthService
    {
        //simple authenticator that finds if 
        //employee exists && 
        //pass && username == pass & username in the db 

        private EmployeeDao employeeDao;

        public AuthService(EmployeeDao employeeDao)
        {
            this.employeeDao = employeeDao;
        }

        public Employee Login(String username, String password)
        {
            //Finds matching employee from extracted file information
            List<Employee> employees = this.employeeDao.GetEmployees();

            Employee authEmployee = employees.Find(employee => employee.Username == username && employee.Password == password);
            
            return authEmployee;
        }
    }
}
