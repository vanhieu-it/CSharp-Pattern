﻿using BuilderPattern.Contracts;
using System;

namespace BuilderPattern.Implementations
{
    class Notification
    {
        public INotificationBuilder NotificationBuilder { get; set; }

        public void SendEmail()
        {
            if (NotificationBuilder == null)
            {
                Console.WriteLine("Please instantiate NotificationBuilder before sending notification.");
            }
            else
            {
                NotificationBuilder.SendEmail();
            }
        }

        public void SendSms()
        {
            if (NotificationBuilder == null)
            {
                Console.WriteLine("Please instantiate NotificationBuilder before sending notification.");
            }
            else
            {
                NotificationBuilder.SendSms();
            }
        }
    }
}
