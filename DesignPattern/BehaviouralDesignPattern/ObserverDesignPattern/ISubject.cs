using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.BehaviouralDesignPattern.ObserverDesignPattern
{
    /// <summary>
    /// Implemented by Cricket data to communicate with observers
    /// </summary>
    public interface ISubject
    {
        public void RegisterObserver(IObserver observer);
        public void UnregisterObserver(IObserver observer);
        public void NotifyObservers();
    }
}
