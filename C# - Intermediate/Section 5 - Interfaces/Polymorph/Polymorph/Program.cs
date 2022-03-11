using System;

namespace Polymorph
{
    public class Mail
    {

    }
    public class MailService
    {
        public void Send(Mail mail)
        {
            Console.WriteLine("Send an email" + mail);
        }

    }
    public class Video
    {

    }
    public class Message
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            var encoder = new VideoEncoder();
            encoder.RegisterNotificationChannel(new MailNotificationChannel());
            encoder.RegisterNotificationChannel(new SmsNotificationChannel());
            encoder.Encode(new Video());
        }
    }
}
