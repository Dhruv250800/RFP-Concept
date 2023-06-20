using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFP_Basics_Concept
{
    internal class Dictonary
    {
        static void Main(String[] args)
        {
            //------------------------- DICTIONARY-------------------------------------

            Dictionary<string, int> st = new Dictionary<string, int>();
            st.Add("Dhruv", 1000);
            st.Add("Rahul", 2000);
            st.Add("Shubham", 3000);

            foreach (var itm in st)
            {
                Console.WriteLine(itm);
            }
        }
    }
}
