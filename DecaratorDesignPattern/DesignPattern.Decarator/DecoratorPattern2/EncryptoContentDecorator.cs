using DesignPattern.Decarator.DAL;

namespace DesignPattern.Decorator.DecoratorPattern2
{
    public class EncryptoContentDecorator : Decorator
    {
        private readonly ISendMessage _sendMessage;
        Context context = new Context();
        public EncryptoContentDecorator(ISendMessage sendMessage) : base(sendMessage)
        {
            _sendMessage = sendMessage;
        }
        public void EncryptoContentCreateMessage(Message message)
        {
            message.MessageSender = "İnsan Kaynakları";
            message.MessageSubject = "Maaş Bordrosu";
            message.MessageReceiver = "Process Team";
            message.MessageContent = "Mail Kontrolü";
            string data = message.MessageContent;
            char[] chars = data.ToCharArray();
            foreach (var item in chars)
            {
                message.MessageContent += Convert.ToChar(item + 3).ToString();
            }
            context.Messages.Add(message);
            context.SaveChanges();
        }
        public override void CreateMessage(Message message)
        {
            base.CreateMessage(message);
            EncryptoContentCreateMessage(message);
        }
    }
}
