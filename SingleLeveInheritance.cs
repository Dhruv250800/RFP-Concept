using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFP_Basics_Concept
{
    internal class SingleLeveInheritance
    {
        public class parentClass
        {
            String EmpName = "Dheuv";
            int Salary = 30000;
            public void DisplayEmpDetail()
            {
                Console.WriteLine("Parent Class :-");
                Console.WriteLine("EmployeeName: " + EmpName + " , " + "Salary: " + Salary);
            }
        }

        public class ChildClass : parentClass
        {

        }
    }
}
