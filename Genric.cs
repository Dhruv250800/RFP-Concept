using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFP_Basics_Concept
{
    internal class Genric
    {
        public void CheckEqual<T>(T val1, T val2)
        {
            if (val1.Equals(val2))
            {
                Console.WriteLine("Values are Equals...");
            }
            else
            {
                Console.WriteLine("Values are Not equal...");
            }
        }
    }
}
