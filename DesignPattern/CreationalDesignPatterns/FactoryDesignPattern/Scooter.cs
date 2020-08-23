using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.CreationalDesignPatterns.FactoryDesignPattern
{
    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>
    public class Scooter : IFactory
    {
        public void Drive(int miles)
        {
            Console.WriteLine("Drive the Scooter : " + miles.ToString() + "km");
        }
    }
}
