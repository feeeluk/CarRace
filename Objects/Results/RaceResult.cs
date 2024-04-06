using Race.Objects.Teams;

namespace Race.Objects.Results
{
    public class RaceResult
    {
        // ****************************************************************
        // Properties
        // ****************************************************************
        public int ResultID { get; set; }
        public int VehicleID { get; set; }
        public VehicleType VehicleType { get; set; }
        public string VehicleMake { get; set; }
        public string VehicleModel { get; set; }
        public int CircuitID { get; set; }
        public Team Team { get; set; }
        public double Time { get; set; }
        public int Position { get; set; }
        public int Points { get; set; }
        public bool Winner { get; set; }
        public bool Podium { get; set; }
        public DateTime ResultDate { get; set; }


        // ****************************************************************
        // Constructor
        // ****************************************************************
        public RaceResult(int id, DateTime resultDate, int vehicle, VehicleType type, string make, string model, int circuit, Team team, double time, int position, int points, bool winner, bool podium)
        {
            ResultID = id;
            ResultDate = resultDate;
            VehicleID = vehicle;
            VehicleType = type;
            VehicleMake = make;
            VehicleModel = model;
            CircuitID = circuit;
            Time = time;
            Position = position;
            Points = points;
            Team = team;
            Winner = winner;
            Podium = podium;
        }
    }
}
