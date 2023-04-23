using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTutotial
{
    abstract class Employee
    {
        //field
        private string name;
        private int salary;

        public Employee()
        {
            Console.WriteLine("Create Employee Object");
        }

        public Employee(string name, int salary)
        {
            this.Name = name;
            this.Salary = salary;
        }

        public string Name { get => name; set => name = value; }
        public int Salary { get => salary; set => salary = value; }

        public virtual void showEmployee()
        {
            Console.WriteLine("Name = " + this.Name);
            Console.WriteLine("Salary = " + this.Salary);
            Console.WriteLine("---------------------");
        }

        public abstract double reportIncome();

    }
}
