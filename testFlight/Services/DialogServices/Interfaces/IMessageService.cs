
namespace testFlight.Services.DialogServices.Interfaces
{
    public interface IMessageService
    {
        public void Show(string message, MessageType type = MessageType.Default);
    }

    public enum MessageType
    {
        Default,
        Warning,
        Error
    }
}
