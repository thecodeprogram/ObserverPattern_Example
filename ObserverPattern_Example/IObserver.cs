/*
This File Created
By: Burak Hamdi TUFAN
On: https://thecodeprogram.com/
At: 21.05.2020
*/

namespace ObserverPattern_Example
{
    //First we have to create an interface to derive all observer classes
    //All observer classes will have update and Warn Methods 
    //They will update the values and if the value is out of limit,
    //it will warn the user
    interface IObserver
    {
        void Update(int newvalue);
        void Warn();
    }
}
