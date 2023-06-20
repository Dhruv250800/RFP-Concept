using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFP_Basics_Concept
{
    internal class DefaultConstructor
    {
        int i;
        String name;
        public DefaultConstructor()
        {
            Console.WriteLine("Default Constructor Called..");
            i = 100;
            name = "karan";
            Console.WriteLine("Name: " + name + "," + "Value of i : " + i);
        }
    }
}
