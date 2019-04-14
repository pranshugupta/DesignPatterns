using BuilderLibrary.BaseLibrary;

namespace BuilderLibrary.Builders
{
    public class HondaBuilder : IVehicleBuilder
    {
        readonly Vehicle _MyVehicle;
        public HondaBuilder()
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
        }

        public void SetBody()
        {
            _MyVehicle.Body = "Bulky";
        }

        public void SetEngine()
        {
            _MyVehicle.Engine = "200CC";
        }

        public void SetModel()
        {
            _MyVehicle.Model = "HONDA ZR";
        }

        public void SetTransmission()
        {
            _MyVehicle.Transmission = "155km/h";
        }
    }
}
