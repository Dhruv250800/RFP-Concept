using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFP_Basics_Concept
{
    public class StatementLambda
    {
        public static Action<string> Greet = name =>
        {
            Console.WriteLine("Hello " + name);
        };
    }
}
