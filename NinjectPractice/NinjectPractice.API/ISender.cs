using NinjectPractice.Contracts;

namespace NinjectPractice.API
{
    public interface ISender
    {
        void Send(Message messageToSend);
    }
}
