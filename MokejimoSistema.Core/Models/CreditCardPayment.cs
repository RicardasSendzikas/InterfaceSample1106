using System;
using MokejimoSistema.Core.Contracts;

namespace MokejimoSistema.Core.Models
{
    public class CreditCardPayment : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Mokėjimas kreditine kortele: {amount:C} buvo sėkmingai apdorotas.");
        }
    }
}