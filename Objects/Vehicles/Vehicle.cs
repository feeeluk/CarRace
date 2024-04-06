using Race.Objects.Teams;

namespace Race.Objects.Vehicles
{
    public abstract class Vehicle
    {
        // ****************************************************************
        // Fields
        // ****************************************************************
        private string _speedCategory;


        // ****************************************************************
        // Properties
        // ****************************************************************    
        public abstract VehicleType VehicleType { get; }
        public abstract int VehicleNumberOfWheels { get; }
        public int VehicleID { get; set; }
        public Team VehicleTeam { get; set; }
        public String VehicleMake { get; set; }
        public String VehicleModel { get; set; }
        public String VehicleColour { get; set; }
        public String VehicleYear { get; set; }
        public int VehicleSpeed { get; set; }
        public bool VehicleStarted { get; set; } = false;
        public String VehicleSpeedCategory { get; set; }
        public abstract int ServiceInterval { get; }
        public virtual bool IsMotorisedVehicle { get; } = false;


        // ****************************************************************
        // Constructor
        // ****************************************************************
        public Vehicle(List<Vehicle> allVehicles, Team team, String make, String model, String colour, String year, int speed)
        {
            VehicleID = allVehicles.Count()+1;
            VehicleTeam = team;
            VehicleMake = make;
            VehicleModel = model;
            VehicleColour = colour;
            VehicleYear = year;
            VehicleSpeed = speed;
            VehicleSpeedCategory = CalculateSpeedCategory(speed);

            allVehicles.Add(this);
        }


        // ****************************************************************
        // Methods
        // ****************************************************************
        public String CalculateSpeedCategory(int speed)
        {
            String category;

            while (true)
            {
                if (speed < 65)
                {
                    category = "slow";
                    return category;
                }

                else if (speed >= 65 && speed < 90)
                {
                    category = "average";
                    return category;
                }

                if (speed >= 90)
                {
                    category = "fast";
                    return category;
                }
            }
        }


        public void Start()
        {
            VehicleStarted = true;
            Console.WriteLine($"  - Vehicle #{VehicleID} - ({VehicleType}) has started moving");
        }


        public void Stop()
        {
            VehicleStarted = false;
            Console.WriteLine($"  - Vehicle #{VehicleID} - ({VehicleType}) has stopped moving");
        }


        public virtual void Crash()
        {
            Console.WriteLine($"  - Vehicle #{VehicleID}  - ( {VehicleType}) has crashed.");
        }


        public abstract void ServiceVehicle();

        public virtual void DNF()
        {
            Console.WriteLine($"The vehicle crashed");
        }
    }
}