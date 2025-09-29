using DesignPattern.Decarator.DAL;

namespace DesignPattern.Decorator.DecoratorPattern2
{
    public class Decorator : ISendMessage
    {
        private readonly ISendMessage _sendMessage;

        public Decorator(ISendMessage sendMessage)
        {
            _sendMessage = sendMessage;
        }

        public virtual void CreateMessage(Message message)
        {
            message.MessageReceiver = "Everyone";
            message.MessageSender = "Manager of Software";
            message.MessageSubject = "Meeting";
            message.MessageContent = "Design Pattern";
            _sendMessage.CreateMessage(message);
        }
    }
}
