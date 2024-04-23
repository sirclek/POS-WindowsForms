using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS;

namespace POS
{
    internal class AuthenticatedEmployee
    {
        private static AuthenticatedEmployee Instance;

        public Employee AuthenticatedEmployeeData { get; private set; }

        public static AuthenticatedEmployee GetInstance()
        {
            if (Instance == null)
            {
                Instance = new AuthenticatedEmployee();
            }
            return Instance;
        }
        //Sets only one employee as the current user of the system
        public void SetEmployee(Employee employee)
        {
            AuthenticatedEmployeeData = employee;
        }

        public void Logout()
        {
            AuthenticatedEmployeeData = null;
        }
    }
}
