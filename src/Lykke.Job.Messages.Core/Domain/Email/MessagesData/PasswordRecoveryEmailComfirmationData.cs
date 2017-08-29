namespace Lykke.Job.Messages.Core.Domain.Email.MessagesData
{
    public class PasswordRecoveryEmailComfirmationData : IEmailMessageData
    {
        public string ConfirmationCode { get; set; }
        public string Year { get; set; }
        public string MessageId()
        {
            return "PasswordRecoveryConfirmationEmail";
        }
    }
}