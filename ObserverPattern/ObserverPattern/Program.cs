using ObserverPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            WeaterStation station = new WeaterStation();
            PhoneDisplay phoneDisplay = new PhoneDisplay(station);
            station.Add(phoneDisplay);
            int temp=station.change_Temp();
            Console.WriteLine(temp);

            Console.ReadLine();
        }


    }
}
