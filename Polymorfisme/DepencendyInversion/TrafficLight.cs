using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorfisme.DepencendyInversion
{
    class TrafficLight : INotificationReceiver
    {
        private Sensor _sensor;

        public TrafficLight()
        {
            _sensor = new Sensor(this);
        }

        public void NotifyAboutVehicle()
        {
            Console.WriteLine("Det har kommet en bil.");
        }
    }
}
