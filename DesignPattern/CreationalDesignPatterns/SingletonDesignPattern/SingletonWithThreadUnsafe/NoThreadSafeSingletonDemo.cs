using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.CreationalDesignPatterns.SingletonDesignPattern.SingletonWithThreadUnsafe
{
    public class NoThreadSafeSingletonDemo
    {
        static int instanceCounter = 0;
        private static NoThreadSafeSingletonDemo singleInstance = null;
        private NoThreadSafeSingletonDemo()
        {
            instanceCounter++;
            Console.WriteLine("Instances created " + instanceCounter);
        }

        public static NoThreadSafeSingletonDemo SingleInstance
        {
            get
            {
                if (singleInstance == null)
                {
                    singleInstance = new NoThreadSafeSingletonDemo();
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
