using System;

namespace CodeRefactoring
{
    /// <summary>
    /// there are three notification services: EmailService, SmsService, and PushNotificationService. 
    /// Each service has a method to send notifications to users through different channels - email, SMS, and 
    /// push notifications, respectively.
    /// This task covers:
    /// 1. Extract Interface
    /// </summary>
    public class EmailService
    {
        public void SendNotification(string userId, string message)
        {
            // Send email notification
            Console.WriteLine($"Sending email notification to user {userId}: {message}");
        }
    }

    public class SmsService
    {
        public void SendNotification(string userId, string message)
        {
            // Send SMS notification
            Console.WriteLine($"Sending SMS notification to user {userId}: {message}");
        }
    }
    public class PushNotificationService
    {
        public void SendNotification(string userId, string message)
        {
            // Send push notification
            Console.WriteLine($"Sending push notification to user {userId}: {message}");
        }
    }

    public class User
    {
        private string userId;
        private EmailService emailService;
        private SmsService smsService;
        private PushNotificationService pushNotificationService;


        public User(string userId, EmailService emailService)
        {
            this.userId = userId;
            this.emailService = emailService;
        }
        public User(string userId, SmsService smsService)
        {
            this.userId = userId;
            this.smsService = smsService;
        }
        public User(string userId, PushNotificationService pushNotificationService)
        {
            this.userId = userId;
            this.pushNotificationService = pushNotificationService;
        }
        public void Notify(string message)
        {
            if (emailService != null)
                emailService.SendNotification(userId, message);
            else if (smsService != null)
                smsService.SendNotification(userId, message);
            else if (pushNotificationService != null)
                pushNotificationService.SendNotification(userId, message);
            else
                Console.WriteLine("No notification chanel provided");
        }
    }

}
