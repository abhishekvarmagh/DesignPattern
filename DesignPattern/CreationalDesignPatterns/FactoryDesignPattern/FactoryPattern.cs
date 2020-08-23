
namespace DesignPattern
{
    using DesignPattern.CreationalDesignPatterns.FactoryDesignPattern;
    using System;

    public class FactoryPattern
    {
        public static void Run()
        {
            VehicleFactory factory = new ConcreteVehicleFactory();

            IFactory scooter = factory.GetVehicle("Scooter");
            scooter.Drive(10);

            IFactory bike = factory.GetVehicle("Bike");
            bike.Drive(20);

            Console.ReadKey();
        }
    }
}
