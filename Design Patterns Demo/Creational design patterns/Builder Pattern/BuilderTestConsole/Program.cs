using BuilderLibrary.BaseLibrary;
using BuilderLibrary.Builders;
using System;

namespace BuilderTestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic manufacturer;
            dynamic vehicle;

            manufacturer = new VehicleManufacturer(new HondaBuilder());
            manufacturer.AssembleVhicle();
            vehicle = manufacturer.GetVehicle();
            vehicle.ShowVehicleInformation();

            manufacturer = new VehicleManufacturer(new SuzukiBuilder());
            manufacturer.AssembleVhicle();
            vehicle = manufacturer.GetVehicle();
            vehicle.ShowVehicleInformation();

            Console.ReadKey();
        }
    }
}
