namespace DependencyInversion
{
    public class SMS : IMessage
    {
        public string PhoneNumber { get; set; }
        public string Message { get; set; }
        public void SendSMS()
        {
            //Send sms
        }

        public void SendMessage()
        {
            //Send sms
        }
    }
}
