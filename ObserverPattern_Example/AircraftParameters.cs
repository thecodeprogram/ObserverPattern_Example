/*
This File Created
By: Burak Hamdi TUFAN
On: https://thecodeprogram.com/
At: 21.05.2020
*/

using System.Collections.Generic;

namespace ObserverPattern_Example
{
    //I will keep all global variables in this class. So I defined them as public static.
    //Because I may need to reach these values from everywhere of the program
    //Here I store the observer indexes in a Dictionary and the other required values.
    //For example I used ObserverIndexes at Program and Aircraft class
    public static class AircraftParameters
    {
        public static Dictionary<string, int> ObserverIndexes = new Dictionary<string, int> {
                { "FuelObserver", 0 }, { "AltiudeObserver", 1 }
            };


        public static int fuelQuantity = 0;
        public static int altitude = 0;
    }
}
