using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFP_Basics_Concept
{
    public class Employeee
    {
        public virtual void CalculateSalary()
        {
            Console.WriteLine("Salary is 1000000");
        }
        public virtual void CalculateBonus()
        {
            Console.WriteLine("Bonus is 1000");
        }
    }

    public class PermanentEmployee : Employeee
    {
        public override void CalculateSalary()
        {
            Console.WriteLine("Permanent Employee Salary is: 2000000");
        }
        public override void CalculateBonus()
        {
            Console.WriteLine("Permanent Employee Bonus is: 2000");
        }
    }

}
