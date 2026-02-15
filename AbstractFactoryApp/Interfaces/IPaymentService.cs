using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryApp.Interfaces
{
    public interface IPaymentService
    {
        void ProcessPayment(decimal amount, string cardNumber);
    }
}
