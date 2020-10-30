using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace Polymorfisme.DepencendyInversion
{
    class Sensor
    {
        private INotificationReceiver _notificationReceiver;

        public Sensor(INotificationReceiver notificationReceiver)
        {
            _notificationReceiver = notificationReceiver;
        }

        public void SendMessage()
        {
            _notificationReceiver.NotifyAboutVehicle();
        }
    }
}
