using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverDP.Observer;

namespace ObserverDP.Subject
{
    internal class FootBall : Ball
    {
        Position myPosition;
        List<IObserver> observers;

        public FootBall()
        {
            myPosition = new Position(0, 0, 0);
            observers = new List<IObserver>();
        }
        public void SetBallPosition(Position position)
        {
            myPosition = position;
        }

        public Position GetBallPosition()
        {
            return myPosition;
        }
        public void AttachObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void DetachObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update(myPosition);
            }
        }
    }
}
