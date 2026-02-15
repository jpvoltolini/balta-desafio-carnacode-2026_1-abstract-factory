using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryApp.Interfaces
{
    public interface IPaymentProcessor
    {
        string ProcessTransaction(decimal amount, string cardNumber);
    }
}
