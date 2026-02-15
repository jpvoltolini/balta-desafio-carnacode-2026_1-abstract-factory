using AbstractFactoryApp.Interfaces;
using AbstractFactoryApp.MercadoPago;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryApp
{
    public class PaymentService : IPaymentService
    {
        private readonly IPaymentLogger _logger;
        private readonly IPaymentProcessor _processor;
        private readonly IPaymentValidator _validator;

        public PaymentService(IPaymentFactory factory)
        {
            _logger = factory.CreateLogger();
            _processor = factory.CreateProcessor();
            _validator = factory.CreateValidator();
        }

        public void ProcessPayment(decimal amount, string cardNumber)
        {
            if (_validator.ValidateCard(cardNumber))
            {                
                var transaction = _processor.ProcessTransaction(amount, cardNumber);
                _logger.Log($"Transação processada: {transaction}");
            }
            else
            {
                _logger.Log("Cartão inválido");
            }
        }
    }
}
