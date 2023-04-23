using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTutotial
{
    class IT:Employee,General
    {
        private int exp;
        public IT(string name, int salary, int exp) : base(name, salary)
        {
            this.exp = exp;
        }

        public override double reportIncome()
        {
            return (base.Salary * 12) * this.exp;
        }

        public string showBonus()
        {
            return "Bonus 55%";
        }

        public override void showEmployee()
        {
            Console.WriteLine("Name = " + base.Name);
            Console.WriteLine("Salary = " + base.Salary);
            Console.WriteLine("Experience = " + this.exp);
            Console.WriteLine("---------------------");
        }

        public void showUniform()
        {
            Console.WriteLine("Uniform : Black Color");
        }
    }
}
