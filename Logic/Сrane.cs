using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public interface Сrane:Switcher //Кран
    {
       
        void PowerUp();
        void PowerDown();
        void ReduceTemperature();
        void IncreaseTemperature();

    }
}
