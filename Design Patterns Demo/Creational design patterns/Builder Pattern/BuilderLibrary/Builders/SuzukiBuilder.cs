using BuilderLibrary.BaseLibrary;

namespace BuilderLibrary.Builders
{
    public class SuzukiBuilder : IVehicleBuilder
    {
        readonly Vehicle _MyVehicle;
        public SuzukiBuilder()
        {
            _MyVehicle = new Vehicle();
        }

        public Vehicle GetVehicle()
        {
            return _MyVehicle;
        }

        public void SetAccessories()
        {
            _MyVehicle.Accessories.Add("Seat Cover");
            _MyVehicle.Accessories.Add("Helmet");
            _MyVehicle.Accessories.Add("Gloves");
            _MyVehicle.Accessories.Add("Break Cover");
            _MyVehicle.Accessories.Add("Bike suit");
        }

        public void SetBody()
        {
            _MyVehicle.Body = "Curvy";
        }

        public void SetEngine()
        {
            _MyVehicle.Engine = "300CC";
        }

        public void SetModel()
        {
            _MyVehicle.Model = "SU - ZR";
        }

        public void SetTransmission()
        {
            _MyVehicle.Transmission = "220 km/h";
        }
    }
}
