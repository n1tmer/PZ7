using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ7
{
    internal class IObservable
    {
        interface iObservable
        {
            void AddObserver(User us);
            void RemoveObserver(User us);
            void NotifyObservers(Celebration name);
        }
    }
}
