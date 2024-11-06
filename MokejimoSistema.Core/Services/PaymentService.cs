using MokejimoSistema.Core.Contracts;

namespace MokejimoSistema.Core.Services
{
    public class PaymentService
    {
        public void ExecutePayment(IPaymentProcessor paymentProcessor, decimal amount)
        {
            paymentProcessor.ProcessPayment(amount);
        }
    }
}