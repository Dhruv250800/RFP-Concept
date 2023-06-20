using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFP_Basics_Concept
{
    internal class MethodOverriding
    {
        // Method overriding :- same method name , and same parameter's
        public virtual void Display(int x, int y)
        {
            Console.WriteLine("Parent Class Executed...");
            int res = x * y;
            Console.WriteLine("Multiplication of X and Y is:" + res);
        }
    }
    internal class Child : Parent
    {
        public override void Display(int x, int y)
        {
            Console.WriteLine("Child class Executed...");
            int res = x + y;
            Console.WriteLine("Addition of X and Y is:" + res);
        }
    }
}
