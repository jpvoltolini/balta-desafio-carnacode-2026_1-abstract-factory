using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryApp.Interfaces
{
    public interface IPaymentFactory
    {
        IPaymentLogger CreateLogger();
        IPaymentProcessor CreateProcessor();
        IPaymentValidator CreateValidator();
    }
}
