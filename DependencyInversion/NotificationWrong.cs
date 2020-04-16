namespace DependencyInversion
{
    public class NotificationWrong
    {
        private Email _email;
        private SMS _sms;
        public NotificationWrong()
        {
            _email = new Email();
            _sms = new SMS();
        }

        public void Send()
        {
            _email.SendEmail();
            _sms.SendSMS();
        }
    }
}
