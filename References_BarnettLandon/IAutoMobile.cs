using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace References_BarnettLandon
{
    internal interface IAutoMobile
    {
        //Interface that our automobile classes inherit from
        public double Speed { get; }

        public int Wheels { get; }

        public string LicensePlate { get; }

        public void Stringify();
    }
}
