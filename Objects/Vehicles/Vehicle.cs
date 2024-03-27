namespace Race.Classes.Vehicles
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
        public int VehicleID { get; set; }
        public abstract VehicleType VehicleType { get; }
        public int VehicleTeamID { get; set; }
        public String VehicleMake { get; set; }
        public String VehicleModel { get; set; }
        public String VehicleColour { get; set; }
        public String VehicleYear { get; set; }
        public abstract int VehicleNumberOfWheels { get; }
        public int VehicleSpeed { get; set; }
        public bool VehicleStart { get; set; } = false;
        public String VehicleSpeedCategory { get; set; }


        // ****************************************************************
        // Constructor
        // ****************************************************************
        public Vehicle(int teamID, String make, String model, String colour, String year, int speed, List<Vehicle> allVehicles)
        {
            VehicleID = allVehicles.Count()+1;
            VehicleTeamID = teamID;
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