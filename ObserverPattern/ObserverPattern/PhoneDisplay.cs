using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
     class PhoneDisplay : IObserver
    {
        public WeaterStation _station;
        public PhoneDisplay(WeaterStation station)
        {
            _station = station;
        }



        public void Update()
        {
            _station.GetTemperature();
        }

    }
}
