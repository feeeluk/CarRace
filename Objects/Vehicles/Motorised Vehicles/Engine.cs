namespace Race.Objects.Vehicles
{
    public class Engine
    {
        // *******************************************************
        // PROPERTIES
        // *******************************************************
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
            engines.Add(this);
        }
    }
}