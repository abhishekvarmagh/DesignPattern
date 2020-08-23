
namespace DesignPattern
{
    using System;

    class DesignPatterns
    {
        static void Main(string[] args)
        {
            char choice;
            do
            {
                Console.Clear();
                Console.WriteLine("--------Design Pattern Demo---------");
                Console.WriteLine("Enter Your Choice");
                Console.WriteLine("1. Creational Design Pattern");
                Console.WriteLine("2. Structural Design Pattern");
                Console.WriteLine("3. Behavioural Design Pattern");
                Console.WriteLine("0. To Exit");
                Console.WriteLine("------------------------------------");
                choice = (char)Console.Read();
                switch(choice)
                {
                        case '1':
                            CreationalDesignPattern.Run();
                            break;
                        case '2':
                            StructuralDesignPattern.Run();
                            break;
                        case '3':
                            BehaviouralDesignPatterns.Run();
                            break;
                        default:
                            Console.WriteLine("Please Enter Valid Choice");
                    break;
                }
            } while (choice !='0');
        }
    }
}
