using System.Collections.Generic;
namespace Polymorph
{
    public class VideoEncoder
    {
        //private readonly MailService _mailService; //no longer need this once the interface is setup 
        //we might want to use more than one notification channel so we need a list 
        private readonly IList<INotificationChannel> _notificationChannels; //list 
        public VideoEncoder() // initialise list in the constructor
        {
            //_mailService = new MailService(); // tight dependancy. Interface can be used here
            _notificationChannels = new List<INotificationChannel>();
        }
        public void Encode(Video video)
        {
            // ...some encode logic
            //_mailService.Send(new Mail());

            foreach (var channel in _notificationChannels) // loop through each notification method in the list and send
            {
                channel.Send(new Message());
            }
        }

        public void RegisterNotificationChannel(INotificationChannel channel)
        {
            _notificationChannels.Add(channel);
        }
    }
}
