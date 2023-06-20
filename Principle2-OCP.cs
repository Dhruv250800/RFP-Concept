using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFP_Basics_Concept
{
    public abstract class MobileBase
    {
        public abstract string CameraInfo();
    }

    public class RedmiDerived : MobileBase
    {
        public override string CameraInfo()
        {
            return "64 mega pixels";
        }
    }

    public class IphoneDerived : MobileBase
    {
        public override string CameraInfo()
        {
            return "120 mexa pixels";
        }
    }


    public class AllMobileInfo
    {
        public void AllInfo(MobileBase obj)
        {
            Console.WriteLine(obj.CameraInfo());
        }
    }
}
