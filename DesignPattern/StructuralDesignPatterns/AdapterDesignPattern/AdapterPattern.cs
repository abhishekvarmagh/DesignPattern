namespace DesignPattern.StructuralDesignPatterns.AdapterDesignPattern
{
    using System;

    public class AdapterPattern
    {
        public static void Run()
        {
            ITarget Itarget = new EmployeeAdapter();
            ThirdPartyBillingSystem client = new ThirdPartyBillingSystem(Itarget);
            client.ShowEmployeeList();

            Console.ReadKey();
        }
    }
}
