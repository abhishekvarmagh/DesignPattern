using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.CreationalDesignPatterns.FactoryDesignPattern
{
    /// <summary>
    /// The Creator Abstract Class
    /// </summary>
    public abstract class VehicleFactory
    {
        public abstract IFactory GetVehicle(string Vehicle);

    }
}
