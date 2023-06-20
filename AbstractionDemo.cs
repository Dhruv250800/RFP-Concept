using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFP_Basics_Concept
{
    public abstract class Animal
    {
        public abstract void Sound();
    }

    public class Dog : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Woof!!!");
        }
    }

    public class Cat : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Mewww");
        }
    }
}
