using System;
using MokejimoSistema.Core.Contracts;

namespace MokejimoSistema.Core.Models
{
    public class PaypalPayment : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Mokėjimas per PayPal: {amount:C} buvo sėkmingai apdorotas.");
        }
    }
}