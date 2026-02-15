using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryApp.Interfaces
{
    public interface IPaymentLogger
    {
        void Log(string message);
    }
}
