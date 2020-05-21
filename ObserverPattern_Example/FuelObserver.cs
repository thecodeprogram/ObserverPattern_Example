/*
This File Created
By: Burak Hamdi TUFAN
On: https://thecodeprogram.com/
At: 21.05.2020
*/

using System;

namespace ObserverPattern_Example
{
    //Then I created the Observer classes. My observer classes are derived
    //from Observer Interface.

    //In Update method it will update the related global variable.
    //After updating it will call the warn method, in warn method
    //if the updated value out of limit it will print failure message.

    class FuelObserver : IObserver
    {
        public void Update(int newvalue)
        {
            AircraftParameters.fuelQuantity = newvalue;
            this.Warn();
        }

        public void Warn()
        {
            if (AircraftParameters.fuelQuantity < 30)
                Console.WriteLine("FUEL LEVEL IS CRITICAL.. Fuel Level is " + AircraftParameters.fuelQuantity);
            else
                Console.WriteLine("Fuel Level is good " );
        }
    }
}
