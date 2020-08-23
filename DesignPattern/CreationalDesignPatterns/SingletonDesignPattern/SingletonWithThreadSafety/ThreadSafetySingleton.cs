namespace DesignPattern
{
    using DesignPattern.CreationalDesignPatterns.SingletonDesignPattern.SingletonWithThreadSafety;
    using System;
    public class ThreadSafetySingleton
    {
        public static void Run()
        {
            LogManagerRequest();
            LogEmployeeRequest();
            Console.ReadKey();
        }
        private static void LogManagerRequest()
        {
            ThreadSafetySingletonDemo fromManager = ThreadSafetySingletonDemo.SingleInstance;
            fromManager.LogMessage("Request Message from Manager");
        }
        private static void LogEmployeeRequest()
        {
            ThreadSafetySingletonDemo fromEmployee = ThreadSafetySingletonDemo.SingleInstance;
            fromEmployee.LogMessage("Request Message from Employee");
        }
    }
}
