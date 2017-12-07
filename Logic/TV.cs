using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public interface TV:Switcher //Телевизор
    {
        void Next();
        void SetChanel(int chanel);
        void SoundUp();
        void SoundDown();
    }
}
