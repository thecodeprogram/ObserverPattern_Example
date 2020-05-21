/*
This File Created
By: Burak Hamdi TUFAN
On: https://thecodeprogram.com/
At: 21.05.2020
*/

using System;
using System.ComponentModel;
using System.Threading;

namespace ObserverPattern_Example
{
    //We will call this Aircraft class as subject class.
    //We will observe the values of this system and it will get values from sensores
    //then send the values to the global variables.
    class Aircraft
    {
        //I will keep the defined obser classes which derived from interface 
        //in an array. This will get easy my task and prevent the confusing.
        IObserver[] observers = new IObserver[AircraftParameters.ObserverIndexes.Count];

        //And I will use the BackGroundWorker component from .Net Framework.
        //This component will be started when everything are ready.
        BackgroundWorker bgw_checkAcParameters = new BackgroundWorker();
 
        //I assume these values are getting from sensores and not loaded the 
        //global paameters. They will be sent via BackGroundWorker.
        private int sensorFuelValue = 0;
        private int sensorAltimeter = 0;

        //Just for debugging :)
        Random rnd = new Random();

        //Here is my constructor. I set the observer array at initializations.
        public Aircraft(IObserver[] _observers)
        {
            observers = _observers;
        }

        //Here we make configurations of the BackGroundWorker and start it.
        public void StartBackgroundObserving()
        {
            bgw_checkAcParameters.WorkerReportsProgress = true;
            bgw_checkAcParameters.WorkerSupportsCancellation = true;
            bgw_checkAcParameters.DoWork += Bgw_checkAcParameters_DoWork;
            bgw_checkAcParameters.RunWorkerAsync();
        }

        //Here is my background workers' task.
        private void Bgw_checkAcParameters_DoWork(object sender, DoWorkEventArgs e)
        {
            //This while loop  will be re-looped every two seconds.
            //It will not freeze the program. Because it is working at background
            while (true)
            {
                //I assume the below variables are getting the datas from sensores. :)
                sensorFuelValue = rnd.Next(0, 100);
                sensorAltimeter = rnd.Next(0, 100);
                //Here I will make the same thing with different values for all
                //observers in the initialized array.
                for (int i = 0; i < observers.Length; i++)
                {
                    //I will check the which observers value and send the data
                    if(i == AircraftParameters.ObserverIndexes["FuelObserver"])
                        this.NotifyObserver(observers[AircraftParameters.ObserverIndexes["FuelObserver"]], sensorFuelValue);
                    else if (i == AircraftParameters.ObserverIndexes["AltiudeObserver"])
                        this.NotifyObserver(observers[AircraftParameters.ObserverIndexes["AltiudeObserver"]], sensorFuelValue);
                }
                 //Here you do not have to use for loop. 
                 //I just want to show a method.
                Thread.Sleep(2000);
            }
        }

        //This function will make the observer updated.
        private void NotifyObserver(IObserver _observer, int _value)
        {
            _observer.Update(_value);
        }
    }
}
