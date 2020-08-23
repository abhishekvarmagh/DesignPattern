using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.CreationalDesignPatterns.SingletonDesignPattern.SingletonWithThreadSafety
{
    public class ThreadSafetySingletonDemo
    {
        static int instanceCounter = 0;
        private static ThreadSafetySingletonDemo singleInstance = null;
        private static readonly object lockObject = new object();
        private ThreadSafetySingletonDemo()
        {
            instanceCounter++;
            Console.WriteLine("Instances created " + instanceCounter);
        }

        public static ThreadSafetySingletonDemo SingleInstance
        {
            get
            {
                lock (lockObject)
                {
                    if (singleInstance == null)
                    {
                        singleInstance = new ThreadSafetySingletonDemo();
                    }
                }
                return singleInstance;
            }
        }
        public void LogMessage(string message)
        {
            Console.WriteLine("Message " + message);
        }
    }
}
