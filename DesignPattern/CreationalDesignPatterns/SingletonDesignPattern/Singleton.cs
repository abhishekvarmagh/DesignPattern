
namespace DesignPattern
{
    using System;
    class Singleton
    {
        public static void Run()
        {
            char choice;
            do
            {
                Console.Clear();
                Console.WriteLine("-------Singleton Pattern Demo-------");
                Console.WriteLine("Enter Your Choice");
                Console.WriteLine("1. No Thread Safe Singleton Design Pattern");
                Console.WriteLine("2. Thread Safe Singleton Design Pattern");
                Console.WriteLine("0. Back");
                Console.WriteLine("------------------------------------");
                choice = (char)Console.Read(); ;
                switch (choice)
                {
                    case '1':
                        NoThreadSafeSingleton.Run();
                        break;
                    case '2':
                        ThreadSafetySingleton.Run();
                        break;
                    default:
                        Console.WriteLine("Please Enter Valid Choice");
                        break;
                }

            } while (choice != '0');
        }
    }
}
