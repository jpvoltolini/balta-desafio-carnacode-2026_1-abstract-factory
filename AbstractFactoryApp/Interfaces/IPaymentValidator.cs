using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryApp.Interfaces
{
    public interface IPaymentValidator
    {
        bool ValidateCard(string cardNumber);
    }
}
