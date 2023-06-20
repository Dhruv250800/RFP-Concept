using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFP_Basics_Concept
{
    public class ArrayConcept
    {
        public void ArrMethod()
        {
            int[] arr = { 40, 20, 30, 50, 10 };

            Console.WriteLine("Array length is : " + arr.Length);
            Console.WriteLine();
            foreach (var i in arr)
            {
                Console.Write(i + " ");
            }


            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------");


            Console.WriteLine("Graetest Element is : " + arr.Max());
            Console.WriteLine("Lowest Element is : " + arr.Min());
            Console.WriteLine("Sum Array is:" + arr.Sum());
            Console.WriteLine("Average is: " + arr.Average());

            Console.WriteLine("--------------------------------------------------------");

            Console.WriteLine("Reversed Array:");
            int[] brr = { 5, 1, 3, 2, 4 };
            Array.Reverse(brr);
            foreach (var i in brr)
            {
                Console.Write(i + " ");
            }


            int[] crr = { 8, 3, 9, 1, 2 };
            Console.WriteLine("Sorted Elements are:-");
            Array.Sort(crr);
            foreach (var i in crr)
            {
                Console.Write(i + " ");
            }


        }
    }
}
