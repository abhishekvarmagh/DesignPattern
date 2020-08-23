
namespace DesignPattern.BehaviouralDesignPattern.ObserverDesignPattern
{
    using System.Collections.Generic;
    public class CricketData : ISubject
    {
        public int runs;
        public int wickets;
        public double overs;
        public List<IObserver> observers;

        public CricketData()
        {
            observers = new List<IObserver>();
        }
        public void NotifyObservers()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update(runs, wickets, overs);
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void UnregisterObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        /// <summary>
        /// Get latest runs from stadium.
        /// </summary>
        /// <returns>return 90 for simplicity.</returns>
        private int GetLatestRuns()
        { 
            return 90;
        }

        /// <summary>
        /// Get latest wickets from stadium.
        /// </summary>
        /// <returns>Return 2 for simplicity.</returns>
        private int GetLatestWickets()
        {  
            return 2;
        }

        /// <summary>
        /// Get latest overs from stadium.
        /// </summary>
        /// <returns>Return 90 for simplicity.returns>
        private double GetLatestOvers()
        {
            return 10.2;
        }

        /// <summary>
        /// This method is used update displays when data changes 
        /// </summary>
        public void DataChanged()
        { 
            runs = GetLatestRuns();
            wickets = GetLatestWickets();
            overs = GetLatestOvers();
            NotifyObservers();
        }
    }
}
