using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDP.Observer
{
    internal interface IObserver
    {
        void Update(Position position);
    }
}
