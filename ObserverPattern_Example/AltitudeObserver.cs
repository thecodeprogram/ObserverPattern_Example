/*
This File Created
By: Burak Hamdi TUFAN
On: https://thecodeprogram.com/
At: 21.05.2020
*/

using System;

namespace ObserverPattern_Example
{
    class AltitudeObserver : IObserver
    {
        //Go FuelObserver class for explanation

        public void Update(int newvalue)
        {
            AircraftParameters.altitude = newvalue;
            this.Warn();
        }

        public void Warn()
        {
            if (AircraftParameters.altitude < 20)
                Console.WriteLine("ALTITUDE IS CRITICAL.. Altitude is " + AircraftParameters.altitude);
            else
                Console.WriteLine("Altitude is good. ");
        }
    }
}
