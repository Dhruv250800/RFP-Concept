using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFP_Basics_Concept
{
    public interface Flying
    {
        void BirdFly();
    }
    public interface Running
    {
        void DogRun();
    }

    public class DerivedFlyingClass : Flying, Running
    {
        public void BirdFly()
        {
            Console.WriteLine("Bird fly is calling...");
        }
        public void DogRun()
        {
            Console.WriteLine("Dog run is calling..");
        }
    }

}
