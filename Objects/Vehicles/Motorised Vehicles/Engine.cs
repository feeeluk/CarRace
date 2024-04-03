namespace Race.Objects.Vehicles
{
    public class Engine
    {
        // *******************************************************
        // PROPERTIES
        // *******************************************************
        List<Engine> Engines { get; set; } = new List<Engine>();
        public int EngineID { get; set; }
        public String EngineName { get; set; }
        public String EngineFuelType { get; set; }


        // *******************************************************
        // CONSTRUCTOR
        // *******************************************************
        public Engine(List<Engine> engines, String name, String engineFuelType)
        {
            EngineID = engines.Count();
            EngineName = name;
            EngineFuelType = engineFuelType;
            Engines.Add(this);
        }
    }
}