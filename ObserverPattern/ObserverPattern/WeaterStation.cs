using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
     class WeaterStation : IObservable
    {
        int temp ;
        public List<IObserver> observers = new List<IObserver>();
        public void Add(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Notify()
        {
            foreach (IObserver item in observers)
            {
                item.Update();
            }
        }

        public void Remove(IObserver observer)
        {
            observers.Remove(observer);

        }

        public int GetTemperature()
        {
            return temp;
        }
        public int change_Temp()
        {
            Random random = new Random();
            int randomNumber = random.Next(-10, 40);
            return randomNumber;
        }

    }
}
