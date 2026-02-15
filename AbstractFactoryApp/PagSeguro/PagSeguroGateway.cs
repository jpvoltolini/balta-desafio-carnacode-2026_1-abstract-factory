using AbstractFactoryApp.Interfaces;

namespace AbstractFactoryApp.PagSeguro
{
    public class PagSeguroGateway : IPaymentFactory
    {
        public IPaymentLogger CreateLogger()
            => new PagSeguroLogger();        

        public IPaymentProcessor CreateProcessor()
            => new PagSeguroProcessor();        

        public IPaymentValidator CreateValidator()
            => new PagSeguroValidator();

    }
}
