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
        public string Type
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
        public string SpeedCategory
        {
            get { return _speedCategory; }
            set
            {
                if (Speed < 65)
                {
                    _speedCategory = "slow";
                }

                else if (Speed >= 65 && Speed < 90)
                {
                    _speedCategory = "average";
                }

                if (Speed >= 90)
                {
                    _speedCategory = "fast";
                }
            }
        }
        public int ID { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Colour { get; set; }
        public string Year { get; set; }
        public int NumberOfWheels { get; set; }
        public int Speed { get; set; }
        public bool VehicleStart { get; private set; }


        // ****************************************************************
        // Constructor
        // ****************************************************************
        public Vehicle(int id, string make, string model, string colour, string year, string type, int noOfWheels, int speed, string speedCategory, bool vehicleStart, List<Vehicle> allVehicles, List<Vehicle> unassignedVehicles, int numberOfVehicles)
        {
            ID = id;
            Make = make;
            Model = model;
            Colour = colour;
            Year = year;
            Type = type;
            NumberOfWheels = noOfWheels;
            Speed = speed;
            SpeedCategory = speedCategory;
            VehicleStart = vehicleStart;

            numberOfVehicles++;
            allVehicles.Add(this);
            unassignedVehicles.Add(this);
        }


        // ****************************************************************
        // Methods
        // ****************************************************************
        public virtual void Start()
        {
            VehicleStart = true;
            Console.WriteLine($"  - Vehicle #{ID} - ({Type}) has started moving");
        }


        public virtual void Stop()
        {
            VehicleStart = false;
            Console.WriteLine($"  - Vehicle #{ID} - ({Type}) has stopped moving");
        }


        public virtual void Crash()
        {
            Console.WriteLine($"  - Vehicle #{ID} - ({Type}) has crashed.");
        }


    }
}