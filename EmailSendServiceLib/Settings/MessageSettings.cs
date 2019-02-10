namespace EmailSendServiceLib.Settings
{
    public class MessageSettings
    {
        private string _MessageFrom; // = "Maxim Toropov";
        public string MessageFrom
        {
            get => _MessageFrom;
            set => _MessageFrom = value;
        }

        private string _MailFrom; // = "@yandex.ru";
        public string MailFrom
        {
            get => _MailFrom;
            set => _MailFrom = value;
        }

        private string _MessageTo; // = "@gmail.com";
        public string MessageTo
        {
            get => _MessageTo;
            set => _MessageTo = value;
        }

        private string _MessageSubject; // = "Subject";
        public string MessageSubject
        {
            get => _MessageSubject;
            set => _MessageSubject = value;
        }

        private string _MessageBody; // = "Body Message";
        public string MessageBody
        {
            get => _MessageBody;
            set => _MessageBody = value;
        }

        private bool _IsMessageBodyHTML; // = false;
        public bool IsMessageBodyHTML
        {
            get => _IsMessageBodyHTML;
            set => _IsMessageBodyHTML = value;
        }

        public MessageSettings(string messageFrom, string mailFrom, string messageTo, string messageSubject, string messageBody, bool isMessageBodyHTML)
        {
            MessageFrom = messageFrom;
            MailFrom = mailFrom;
            MessageTo = messageTo;
            MessageSubject = messageSubject;
            MessageBody = messageBody;

            IsMessageBodyHTML = isMessageBodyHTML;
        }
    }
}
