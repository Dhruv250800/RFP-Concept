using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFP_Basics_Concept
{
    public class ArrayListDemo
    {
        public void ArrayListMethod()
        {
            ArrayList list = new ArrayList();

            // Adding new element at the last
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(40);
            list.Add(50);
            list.Add("Karan");
            list.Add(false);
            list.Add("krishna");
            foreach (var i in list)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("--------------------------------------------");

            // Removing  particular Element 
            list.Remove(40);
            foreach (var i in list)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("--------------------------------------------");


            // Removing at particulat index 
            list.RemoveAt(2);
            foreach (var i in list)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("--------------------------------------------");

            // insert new element at particular index
            list.Insert(1, 1000);
            foreach (var i in list)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("--------------------------------------------");

            // Check Element is present or not

            Console.WriteLine(list.Contains(1000));
            Console.WriteLine("--------------------------------------------");



        }
    }
}
