
namespace DesignPattern.BehaviouralDesignPattern.ObserverDesignPattern
{
    using System;

    public class ObserverPattern
    {
        public static void Run()
        {
            CurrentScoreDisplay currentScoreDisplay = new CurrentScoreDisplay();
            AverageScoreDisplay averageScoreDisplay = new AverageScoreDisplay();

            CricketData cricketData = new CricketData();

            cricketData.RegisterObserver(currentScoreDisplay);
            cricketData.RegisterObserver(averageScoreDisplay);

            Console.WriteLine("------------------------------------");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Register Two User.");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("------------------------------------");
            cricketData.DataChanged();

            Console.WriteLine("------------------------------------");
            Console.WriteLine("------------------------------------");
            cricketData.UnregisterObserver(averageScoreDisplay);
            Console.WriteLine("Unregister One User");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("------------------------------------");
            cricketData.DataChanged();

            Console.ReadKey();
        }
    }
}
