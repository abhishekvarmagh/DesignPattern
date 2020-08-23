namespace DesignPattern
{
    using System;
    class CreationalDesignPattern
    {
        public static void Run()
        {
            char choice;
            do
            {
                Console.Clear();
                Console.WriteLine("------Creational Pattern Demo-------");
                Console.WriteLine("Enter Your Choice");
                Console.WriteLine("1. Singleton Design Pattern");
                Console.WriteLine("2. Factory Design Pattern");
                Console.WriteLine("0. Go Back");
                Console.WriteLine("------------------------------------");
                choice = (char)Console.Read(); ;
                switch (choice)
                {
                    case '1':
                        Singleton.Run();
                        break;
                    case '2':
                        FactoryPattern.Run();
                        break;
                    default:
                        Console.WriteLine("Please Enter Valid Choice");
                        break;
                }

            } while (choice != '0');
        }
    }
}
