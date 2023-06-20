using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFP_Basics_Concept
{
    internal class ExceptionalHandling
    {
        public void CheckDivision()
        {
            try
            {
                int x = 100;
                int y = 0;
                int res = x / y;
                Console.WriteLine("Division result is :" + res);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            int rollNum = 54875;
            Console.WriteLine("My roll num is : " + rollNum);
        }
    }
}
