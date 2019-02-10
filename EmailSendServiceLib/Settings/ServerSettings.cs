namespace EmailSendServiceLib.Settings
{
    public class ServerSettings
    {
        private string _ServerAddress; // = "smtp.yandex.ru";
        public string ServerAddress
        {
            get => _ServerAddress;
            set => _ServerAddress = value;
        }

        private int _ServerPort; // = 25;
        public int ServerPort
        {
            get => _ServerPort;
            set => _ServerPort = value;
        }

        public ServerSettings(string serverAddress, int serverPort)
        {
            ServerAddress = serverAddress;
            ServerPort = serverPort;
        }
    }
}
