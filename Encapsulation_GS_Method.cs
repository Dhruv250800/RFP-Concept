using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFP_Basics_Concept
{
    internal class Encapsulation_GS_Method
    {
        private int age;

        public int myProperty
        {
            get
            {
                return this.age;
            }
            set
            {
                age = value;
            }
        }
    }
}
