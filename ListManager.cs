using Race.Classes.Vehicles;
using System;
using System.Collections.Generic;

namespace Race
{
    public class ListManager
    {
        public List<Vehicle> AllVehicles { get; set; }
        public List<Vehicle> UnassignedVehicles { get; set; }
        public int NumberOfVehicles { get; private set; } = 1;

        public ListManager()
        {
            AllVehicles = new List<Vehicle>();
            UnassignedVehicles = new List<Vehicle>();
            NumberOfVehicles = 1;
        }
    }
}
