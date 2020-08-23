
namespace DesignPattern
{
    using DesignPattern.CreationalDesignPatterns.SingletonDesignPattern.SingletonWithThreadUnsafe;
    using System;

    public class NoThreadSafeSingleton
    {
        public static void Run()
        {
            NoThreadSafeSingletonDemo fromManager = NoThreadSafeSingletonDemo.SingleInstance;
            fromManager.LogMessage("Request Message From Manager");
            NoThreadSafeSingletonDemo fromEmployee = NoThreadSafeSingletonDemo.SingleInstance;
            fromEmployee.LogMessage("Request Message From Employee");
            Console.ReadKey();
        }
    }
}
