using System;

namespace OOPTutotial
{
    class Program
    {
        static void Main(string[] args)
        {
            //object
            Accounting emp1 = new Accounting("jane",50000,"female");
            Sale emp2 = new Sale("jojo", 100000, "rayong");
            IT emp3 = new IT("nut", 80000, 5);

            //Company.addEmployee(emp1);
            //Company.addEmployee(emp2);
            //Company.addEmployee(emp3);
            emp1.showUniform();

            //Company.getEmployees();

            //Console.WriteLine("Name = " + Company.name);
            //Console.WriteLine("Founder = " + Company.founder);
            Console.ReadKey();
        }
    }
}