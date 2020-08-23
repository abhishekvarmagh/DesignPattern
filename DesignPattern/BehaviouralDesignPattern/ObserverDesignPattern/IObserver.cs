
namespace DesignPattern.BehaviouralDesignPattern.ObserverDesignPattern
{
    /// <summary>
    /// This interface is implemented by all those classes that are to be updated whenever there is an update from CricketData
    /// </summary>
    public interface IObserver
    {
        public void Update(int runs, int wickets,
                      double overs);
    }
}
