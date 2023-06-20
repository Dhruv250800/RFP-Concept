using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFP_Basics_Concept
{
    internal class MultilevelInheritance
    {
        public class GrandParent
        {
            int salary = 100;
            String name = "Krishna";

            public void DisplayDetail()
            {
                Console.WriteLine("Grand Parent Class...");
                Console.WriteLine("Salary: " + salary);
                Console.WriteLine("Name: " + name);
            }
        }

        public class Parent : GrandParent
        {
            int age = 23;
            String EmpName = "Karan";
            public void DisplayEmpDetailOnParent()
            {
                Console.WriteLine("Parent Class...");
                Console.WriteLine("Employee name: " + EmpName + " , " + "Employee Age :" + age);
            }
        }

        public class Child : Parent
        {

        }
    }
}
