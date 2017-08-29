using System;

namespace Lykke.Job.Messages.Core.Domain.Email.MessagesData
{
    public class FreezePeriodNotificationData : IEmailMessageData
    {
        public DateTime FreezePeriod { get; set; }
        public string Year { get; set; }
        public string MessageId()
        {
            return "FreezePeriodNotificationEmail";
        }
    }
}