using DesignPattern.Decarator.DAL;

namespace DesignPattern.Decorator.DecoratorPattern2
{
    public class SubjectIDDecorator : Decorator
    {
        private readonly ISendMessage _sendMessage;
        Context context = new Context();
        public SubjectIDDecorator(ISendMessage sendMessage) : base(sendMessage)
        {
            _sendMessage = sendMessage;
        }
        public void SubjectIdSendMessage(Message message)
        {
            if (message.MessageSubject == "1")
            {
                message.MessageSubject = "Etkinlik";
            }
            if (message.MessageSubject == "2")
            {
                message.MessageSubject = "Toplantı";
            }
            if (message.MessageSubject == "3")
            {
                message.MessageSubject = "Uyarı";
            }
            if (message.MessageSubject == "4")
            {
                message.MessageSubject = "Bilgi";
            }
            context.Messages.Add(message);
            context.SaveChanges();
        }
        public override void CreateMessage(Message message)
        {
            base.CreateMessage(message);
            SubjectIdSendMessage(message);
        }
    }
}
