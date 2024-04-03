using Race.Objects.Vehicles;

namespace Race.ObjectsManagers
{
    public class MotorisedVehicleManager
    {
        // ****************************************************************
        // Properties
        // ****************************************************************
        public List<MotorisedVehicle> MotorisedVehicles { get; set; }


        // ****************************************************************
        // Constructor
        // ****************************************************************
        public MotorisedVehicleManager()
        {
            MotorisedVehicles = new List<MotorisedVehicle>();
        }

        // ****************************************************************
        // Methods
        // ****************************************************************

    }
}
