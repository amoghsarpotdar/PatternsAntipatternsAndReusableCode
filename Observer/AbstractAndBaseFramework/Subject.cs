using System.Collections.Generic;

namespace Observer.AbstractAndBaseFramework
{
    abstract class Subject
    {
        private List<Observer> _observers = new List<Observer>();

        public void Attach(Observer observer)
        {
            _observers.Add(observer);
        }

        public void Detach(Observer observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (Observer ob in _observers)
            {
                ob.Update();
            }
        }
    }
}
