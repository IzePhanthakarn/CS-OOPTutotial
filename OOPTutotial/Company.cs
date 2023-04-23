using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOPTutotial
{
    sealed class Company
    {
        public static string cname = "IzePhanthakarn Dev";
        public static string founder = "Phanthakarn Khumphai";
        public static List<Employee> employees = new List<Employee>();

        public static void addEmployee(Employee person)
        {
            employees.Add(person);
        }

        public static void getEmployees()
        {
            foreach (Employee person in employees)
            {
                person.showEmployee();
            }
        }
    }
}
