using DesignPattern.Decarator.DAL;

namespace DesignPattern.Decorator.DecoratorPattern2
{
    public class EncryptoSubjectDecorator : Decorator
    {
        private readonly ISendMessage _sendMessage;
        Context context = new Context();
        public EncryptoSubjectDecorator(ISendMessage sendMessage) : base(sendMessage)
        {
            _sendMessage = sendMessage;
        }
        public void EncryptoSubjectCreateMessage(Message message)
        {
            message.MessageSender = "Ceo of Company";
            message.MessageSubject = "Encrypted Subject";
            message.MessageReceiver = "Software Team";
            message.MessageContent = "Encrypted Content";
            string data = message.MessageSubject;
            char[] chars = data.ToCharArray();
            foreach (var item in chars)
            {
                message.MessageSubject += Convert.ToChar(item + 3).ToString();
            }
            context.Messages.Add(message);
            context.SaveChanges();
        }
        public override void CreateMessage(Message message)
        {
            base.CreateMessage(message);
            EncryptoSubjectCreateMessage(message);
        }
    }
}
