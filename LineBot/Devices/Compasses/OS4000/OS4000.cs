using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LineBot.Interfaces;

namespace LineBot.Devices.Compasses.OS4000
{
    // This class is intended to interact with an OS4000 Series Compass 

    public class OS4000 : ICompass
    {
        public double GetHeading()
        {
            throw new NotImplementedException();
        }

        public double GetPitch()
        {
            throw new NotImplementedException();
        }

        public double GetRoll()
        {
            throw new NotImplementedException();
        }
    }
}
