namespace Race.Objects.Vehicles;

public abstract class MotorisedVehicle : Vehicle
{
    // *******************************************************
    // PROPERTIES
    // *******************************************************
    public Engine MotorisedVehicleEngine { get; set; }
    public FuelTank MotorisedVehicleFuelTank { get; set; }
    public override bool IsMotorisedVehicle => true;


    // *******************************************************
    // CONSTRUCTOR
    // *******************************************************
    public MotorisedVehicle(List<Vehicle> vehicles, int teamID, String make, String model, String colour, String year, int speed, List<MotorisedVehicle> motorisedVehicles, Engine engine, FuelTank fuelTank)
        : base(vehicles, teamID, make, model, colour, year, speed)
    {
        MotorisedVehicleEngine = engine;
        MotorisedVehicleFuelTank = fuelTank;
        motorisedVehicles.Add(this);
    }


    // *******************************************************
    // PUBLIC METHODS
    // *******************************************************
    public void StartEngine()
    {
        Console.WriteLine($"Start engine");
    }


    public void StopEngine()
    {
        Console.WriteLine($"Stop engine");
    }


    public override void ServiceVehicle()
    {
        ChangeOil();
        ChangeOilFilter();
    }


    // *******************************************************
    // PRIVATE METHODS
    // *******************************************************
    private void ChangeOil()
    {
        Console.WriteLine("Change engine oil");
    }

    private void ChangeOilFilter()
    {
        Console.WriteLine("Change engine oil filter");
    }

}