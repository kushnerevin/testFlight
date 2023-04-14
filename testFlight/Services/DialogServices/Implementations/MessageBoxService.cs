using System.Windows;
using testFlight.Services.DialogServices.Interfaces;

namespace testFlight.Services.DialogServices.Implementations
{
    internal class MessageBoxService : IMessageService
    {
        public void Show(string message, MessageType type = MessageType.Default)
        {
            MessageBoxImage messageBoxImage;
            string caption;

            switch (type)
            {
                case MessageType.Default:
                default:
                    messageBoxImage = MessageBoxImage.None;
                    caption = string.Empty;
                    break;
                case MessageType.Warning:
                    messageBoxImage = MessageBoxImage.Warning;
                    caption = "Внимание";
                    break;
                case MessageType.Error:
                    messageBoxImage = MessageBoxImage.Error;
                    caption = "Ошибка";
                    break; 
            }

            MessageBox.Show(message, caption, MessageBoxButton.OK, messageBoxImage);
        }
    }
}
