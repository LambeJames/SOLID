using System.Collections.Generic;

namespace DependencyInversion
{
    public class NotificationCorrect
    {
        private ICollection<IMessage> _messages;

        public NotificationCorrect(ICollection<IMessage> messages)
        {
            this._messages = messages;
        }

        public void Send()
        {
            foreach (var message in _messages)
            {
                message.SendMessage();
            }
        }
    }
}
