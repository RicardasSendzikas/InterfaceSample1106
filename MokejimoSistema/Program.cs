using System;
using MokejimoSistema.Core.Models;
using MokejimoSistema.Core.Services;

class Program
{
    static void Main(string[] args)
    {
        PaymentService paymentService = new PaymentService();

        // Apdirbti mokėjimą kreditine kortele
        IPaymentProcessor creditCardPayment = new CreditCardPayment();
        paymentService.ExecutePayment(creditCardPayment, 100.00m);

        // Apdirbti mokėjimą per PayPal
        IPaymentProcessor paypalPayment = new PaypalPayment();
        paymentService.ExecutePayment(paypalPayment, 50.00m);
    }
}