namespace DependencyInversion
{
    public class Email : IMessage
    {
        public string ToAddress { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public void SendEmail()
        {
            //Send email
        }

        public void SendMessage()
        {
            //Send email
        }
    }
}
