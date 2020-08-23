
namespace DesignPattern
{
    using DesignPattern.StructuralDesignPatterns.AdapterDesignPattern;
    using System;
    class StructuralDesignPattern
    {
        public static void Run()
        {
            char choice;
            do
            {
                Console.Clear();
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Enter Your Choice");
                Console.WriteLine("1. Adapter Design Pattern");
                Console.WriteLine("0. Go Back");
                Console.WriteLine("------------------------------------");
                choice = (char)Console.Read();
                switch (choice)
                {
                    case '1':
                        AdapterPattern.Run();
                        break;
                    default:
                        Console.WriteLine("Please Enter Valid Choice");
                        break;
                }

            } while (choice != '0');
        }
    }
}
