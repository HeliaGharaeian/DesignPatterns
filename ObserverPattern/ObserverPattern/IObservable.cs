using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public interface IObservable
    {
        public void Add(IObserver observer);
        public void Remove(IObserver observer);
        public void Notify();

    }
}
