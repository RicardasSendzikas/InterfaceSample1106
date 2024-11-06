namespace MokejimoSistema.Core.Contracts
{
    public interface IPaymentProcessor
    {
        void ProcessPayment(decimal amount);
    }
}