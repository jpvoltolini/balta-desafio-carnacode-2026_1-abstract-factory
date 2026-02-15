using AbstractFactoryApp.Interfaces;

namespace AbstractFactoryApp.MercadoPago
{
    public class MercadoPagoGateway : IPaymentFactory
    {
        public IPaymentLogger CreateLogger()
            => new MercadoPagoLogger();        

        public IPaymentProcessor CreateProcessor()
            => new MercadoPagoProcessor();      

        public IPaymentValidator CreateValidator()
            => new MercadoPagoValidator();
    }
}
