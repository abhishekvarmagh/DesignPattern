using System;

namespace DesignPattern.BehaviouralDesignPattern.ObserverDesignPattern
{
    public class AverageScoreDisplay : IObserver
    {
        private double RunRate;
        private int PredictedScore;

        public void Update(int run, int wickets, double overs)
        {
            this.RunRate = run / overs;
            this.PredictedScore = (int)(this.RunRate * 50);
            Display();
        }

        public void Display()
        {
            Console.WriteLine("Average Score Display");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Run Rate : " + this.RunRate);
            Console.WriteLine("Predicted Score : " + this.PredictedScore);
        }
    }
}
