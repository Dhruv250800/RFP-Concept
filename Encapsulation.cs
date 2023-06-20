using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFP_Basics_Concept
{
    internal class Encapsulation
    {
        // Encapsulation achive by public methods
        private String name;
        private int salary;

        public void Set()
        {
            name = "Karan";
            salary = 30000;
        }
        public void Get()
        {
            Set();
            Console.WriteLine("NAME : " + name);
            Console.WriteLine("Salary: " + salary);
        }
    }
}
