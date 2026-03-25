using System;
using System.Collections.Generic;
using System.Text;

namespace Modul4_103022400044
{
    public class MesinKopi
    {
        private StateMesin currentState;

        public MesinKopi()
        {
            currentState = StateMesin.OFF;
        }

        public void UbahState(StateMesin nextState)
        {
            if (currentState == StateMesin.OFF && nextState == StateMesin.STANDBY)
            {
                Console.WriteLine("Mesin OFF berubah menjadi StandBy");
                currentState = nextState;
            }
            else if (currentState == StateMesin.STANDBY && nextState == StateMesin.BREWING)
            {
                Console.WriteLine("Mesin StandBy berubah menjadi Brewing");
                currentState = nextState;
            }
            else if (currentState == StateMesin.BREWING && nextState == StateMesin.STANDBY)
            {
                Console.WriteLine("Mesin Brewing berubah menjadi StandBy");
                currentState = nextState;
            }
            else if (currentState == StateMesin.STANDBY && nextState == StateMesin.MAINTENANCE)
            {
                Console.WriteLine("Mesin StandBy berubah menjadi Maintenance");
                currentState = nextState;
            }
            else if (currentState == StateMesin.MAINTENANCE && nextState == StateMesin.STANDBY)
            {
                Console.WriteLine("Mesin Maintenance berubah menjadi StandBy");
                currentState = nextState;
            }
            else if (currentState == StateMesin.STANDBY && nextState == StateMesin.OFF)
            {
                Console.WriteLine("Mesin Standby berubah menjadi Off");
                currentState = nextState;
            }
            else 
            { 
                Console.WriteLine("Perubahan state tiadak valid");
            }
        }
    }
}
