using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic;

namespace Domain
{ 
    public abstract class Actuator : Entity
    {
        public abstract void DoCommand(string command);
        public abstract string[] GetAllCommands();
    }
    //public class Device : Actuator,Kettle
    //{
    //    private string[] commands;
    //    private int lightPower;

    //    public Device(params string[] commands)
    //    {
    //        this.commands = commands;
    //    }

    //    public override void DoCommand(string command)
    //    {
            
    //    }
    //    public override string[] GetAllCommands()
    //    {
    //        return commands;
    //    }

    //    public void SwitchOff()
    //    {
            
    //    }
    //    public void SwitchOn()
    //    {
            
    //    }
    //}
    ///*
    //вешь = switcher;                                     свет , чайник , кофемолка , 
    //вешь = switcher + dimmer;                            свет ,
    //вешь = switcher + chanel;                            радио , 
    //вешь = switcher + lock;                              дверь , ворота , калитка , 
    //вешь = switcher + tester;                            
    //вешь = switcher + chanel + dimmer;                   радио , телевизор , 
    //вешь = switcher + lock + dimmer;                     
    //вешь = switcher + tester + dimmer;
    //вешь = switcher + lock + dimmer + chanel;
    //вешь = switcher + tester + dimmer + chanel;
    //вешь = switcher + tester + dimmer + chanel + lock;
    // */

}