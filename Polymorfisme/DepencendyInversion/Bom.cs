using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorfisme.DepencendyInversion
{
    class Bom : INotificationReceiver
    {
        public Bom()
        {
            var sensor = new Sensor(this);
        }

        public void NotifyAboutVehicle()
        {
           
        }
    }
}
