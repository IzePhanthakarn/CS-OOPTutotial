using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTutotial
{
    class Accounting:Employee,General
    {
        private string gender;
        public Accounting(string name,int salary, string gender):base(name,salary) 
        {
            this.gender = gender;
        }
        public override double reportIncome()
        {
            return base.Salary * 12;
        }

        public string showBonus()
        {
            return "Bonus 20%";
        }

        public override void showEmployee()
        {
            Console.WriteLine("Name = " + base.Name);
            Console.WriteLine("Salary = " + base.Salary);
            Console.WriteLine("Gender = " + this.gender);
            Console.WriteLine("---------------------");
        }

        public void showUniform()
        {
            Console.WriteLine("Uniform : White Color");
        }
    }
}
