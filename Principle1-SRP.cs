using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFP_Basics_Concept
{
    internal class Principle1_SRP
    {
        internal class Vehicle
        {
            public void GetVehicleColor()
            {
                Console.WriteLine("Black");
            }
        }
        internal class Email
        {
            public void EmailSend()
            {
                Console.WriteLine("Sending Email...");
            }
        }
    }
}
