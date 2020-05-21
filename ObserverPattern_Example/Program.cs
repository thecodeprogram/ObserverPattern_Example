/*
This File Created
By: Burak Hamdi TUFAN
On: https://thecodeprogram.com/
At: 21.05.2020
*/

using System;

namespace ObserverPattern_Example
{
    class Program
    {
        //I will initialize the observers in an array and 
        //i will use this array from everywhere at the program
        static IObserver[] observers = new IObserver[AircraftParameters.ObserverIndexes.Count];

        static void Main(string[] args)
        {
            Console.Title = "Observer Design Pattern Example - Thecodeprogram";
            //Then I will inser them with specified indexes
            observers[AircraftParameters.ObserverIndexes["FuelObserver"]] = new FuelObserver();
            observers[AircraftParameters.ObserverIndexes["AltiudeObserver"]] = new AltitudeObserver();

            //Last I will send them to the subject class
            //After Everythig ready I will start the background thread to make observing.
            Aircraft ac = new Aircraft(observers);
            ac.StartBackgroundObserving();

            Console.ReadLine();
        }
    }
}
