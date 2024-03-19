using System;
using System.Collections.Generic;

namespace Race.Classes.Vehicles
{
    public abstract class Vehicle
    {
        // ****************************************************************
        // Fields
        // ****************************************************************
        private string _type;
        private string _speedCategory;


        // ****************************************************************
        // Properties
        // ****************************************************************
        public string VehicleType
        {
            get { return _type; }
            set
            {
                if (value == "CAR" || value == "Car" || value == "car")
                {
                    _type = value.ToLower();
                }

                else if (value == "BIKE" || value == "Bike" || value == "bike")
                {
                    _type = value.ToLower();
                }

                else if (value == "TRUCK" || value == "Truck" || value == "truck")
                {
                    _type = value.ToLower();
                }

                else
                {
                    _type = "invalid vehicle type";
                }
            }
        }
        public string VehicleSpeedCategory
        {
            get { return _speedCategory; }
            set
            {
                if (VehicleSpeed < 65)
                {
                    _speedCategory = "slow";
                }

                else if (VehicleSpeed >= 65 && VehicleSpeed < 90)
                {
                    _speedCategory = "average";
                }

                if (VehicleSpeed >= 90)
                {
                    _speedCategory = "fast";
                }
            }
        }
        public int VehicleID { get; set; }
        public int VehicleTeamID { get; set; }
        public string VehicleMake { get; set; }
        public string VehicleModel { get; set; }
        public string VehicleColour { get; set; }
        public string VehicleYear { get; set; }
        public int VehicleNumberOfWheels { get; set; }
        public int VehicleSpeed { get; set; }
        public bool VehicleStart { get; private set; }
        

        // ****************************************************************
        // Constructor
        // ****************************************************************
        public Vehicle(int id, int teamID, string make, string model, string colour, string year, string type, int noOfWheels, int speed, string speedCategory, bool vehicleStart, List<Vehicle> allVehicles, List<Vehicle> unassignedVehicles)
        {
            VehicleID = id;
            VehicleTeamID = teamID;
            VehicleMake = make;
            VehicleModel = model;
            VehicleColour = colour;
            VehicleYear = year;
            VehicleType = type;
            VehicleNumberOfWheels = noOfWheels;
            VehicleSpeed = speed;
            VehicleSpeedCategory = speedCategory;
            VehicleStart = vehicleStart;

            allVehicles.Add(this);
        }


        // ****************************************************************
        // Methods
        // ****************************************************************
        public virtual void Start()
        {
            VehicleStart = true;
            Console.WriteLine($"  - Vehicle #{VehicleID} - ({VehicleType}) has started moving");
        }


        public virtual void Stop()
        {
            VehicleStart = false;
            Console.WriteLine($"  - Vehicle #{VehicleID} - ({VehicleType}) has stopped moving");
        }


        public virtual void Crash()
        {
            Console.WriteLine($"  - Vehicle #{VehicleID}  - ( {VehicleType}) has crashed.");
        }


    }
}