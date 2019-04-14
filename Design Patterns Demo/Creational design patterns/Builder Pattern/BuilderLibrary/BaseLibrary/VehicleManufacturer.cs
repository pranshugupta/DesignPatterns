namespace BuilderLibrary.BaseLibrary
{
    public class VehicleManufacturer
    {
        readonly IVehicleBuilder _VehicleBuilder;
        public VehicleManufacturer(IVehicleBuilder vehicleBuilder)
        {
            _VehicleBuilder = vehicleBuilder;
        }

        public void AssembleVhicle()
        {
            _VehicleBuilder.SetBody();
            _VehicleBuilder.SetModel();
            _VehicleBuilder.SetEngine();
            _VehicleBuilder.SetTransmission();
            _VehicleBuilder.SetAccessories();
        }

        public Vehicle GetVehicle()
        {
            return _VehicleBuilder.GetVehicle();
        }
    }
}
