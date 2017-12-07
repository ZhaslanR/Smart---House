using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public interface MicrowaveOven:Switcher //Микравалновка
    {
   
        void SetTemperature(int temperature);
        void SetTime(int time);

    }
}
