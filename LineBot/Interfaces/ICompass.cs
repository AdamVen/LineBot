using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineBot.Interfaces
{
    interface ICompass
    {
        double GetHeading();

        double GetPitch();

        double GetRoll();
    }
}
