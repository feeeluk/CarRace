using Race.Objects.Vehicles;

namespace Race.ObjectsManagers
{
    public class FuelTankManager
    {
        // ****************************************************************
        // Properties
        // ****************************************************************
        public List<FuelTank> FuelTanks { get; set; }


        // ****************************************************************
        // Constructor
        // ****************************************************************
        public FuelTankManager()
        {
            FuelTanks = new List<FuelTank>();
        }

        // ****************************************************************
        // Methods
        // ****************************************************************

    }
}
