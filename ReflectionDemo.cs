using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFP_Basics_Concept
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Console.WriteLine("Hello , GoodMorning/ Good AfterNoon / GoodEvening");
            Console.WriteLine("NAME : " + name + " , " + "AGE : " + age);
        }
    }
}
