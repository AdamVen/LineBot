using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LineBot.Interfaces;

namespace LineBot.TestingFakes
{
    class FakeCompass : ICompass
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
