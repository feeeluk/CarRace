using System;
using System.Collections.Generic;

namespace Race
{
    public abstract class Vehicle
    {
        // ****************************************************************
        // Fields
        // ****************************************************************
        public static List<Vehicle> allVehicles = new List<Vehicle>();
        public static List<Vehicle> unassignedVehicles = new List<Vehicle>();
        private string _type;
        private string _speedCategory;
        private int _id;
        public static int numberOfVehicles = 1;


        // ****************************************************************
        // Properties
        // ****************************************************************
        public string Make { get; set; }
        public string Model { get; set; }
        public string Colour { get; set; }
        public string Year { get; set; }
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
        public int NumberOfWheels { get; set; }
        public int Speed { get; set; }
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
        public int ID
        {
            get { return _id; }
            set
            {
                _id = NumberOfVehicles;
            }
        }
        public static int NumberOfVehicles { get; set; }


        // ****************************************************************
        // Constructor
        // ****************************************************************
        public Vehicle(int id, string make, string model, string colour, string year, string type, int noOfWheels, int speed, string SpeedCategory)
        {
            ID = id;
            Make = make;
            Model = model;
            Colour = colour;
            Year = year;
            Type = type;
            NumberOfWheels = noOfWheels;
            Speed = speed;

            NumberOfVehicles++;
            allVehicles.Add(this);
            unassignedVehicles.Add(this);
        }


        // ****************************************************************
        // Methods
        // ****************************************************************
        public virtual void StartMoving()
        {
            Console.WriteLine($"    - Vehicle #{ID} - ({Type}) has started moving.");
        }


        public virtual void StopMoving()
        {
            Console.WriteLine($"    - Vehicle #{ID} - ({Type}) has stopped moving.");
        }


        public virtual void Crash()
        {
            Console.WriteLine($"    - Vehicle #{ID} - ({Type}) has crashed.");
        }


    }
}