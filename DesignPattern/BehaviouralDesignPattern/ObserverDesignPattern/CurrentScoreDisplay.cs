namespace DesignPattern.BehaviouralDesignPattern.ObserverDesignPattern
{
    using System;
    public class CurrentScoreDisplay : IObserver
    {
        private int runs, wickets;
        private double overs;

        public void Update(int runs, int wickets,
                           double overs)
        {
            this.runs = runs;
            this.wickets = wickets;
            this.overs = overs;
            Display();
        }

        public void Display()
        {
            Console.WriteLine("Current Score Display");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Run : " + this.runs);
            Console.WriteLine("Wicket : " + this.wickets);
            Console.WriteLine("Overs : " + this.overs);
        }
    }
}
