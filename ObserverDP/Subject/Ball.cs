using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverDP.Observer;

namespace ObserverDP.Subject
{
    internal interface Ball
    {
        void AttachObserver(IObserver observer);
        void DetachObserver(IObserver observer);
        void NotifyObservers();
    }
}
