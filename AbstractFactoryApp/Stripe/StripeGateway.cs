using AbstractFactoryApp.Interfaces;

namespace AbstractFactoryApp.Stripe
{
    public class StripeGateway : IPaymentFactory
    {
        public IPaymentLogger CreateLogger()
            => new StripeLogger();        

        public IPaymentProcessor CreateProcessor()
            => new StripeProcessor();        

        public IPaymentValidator CreateValidator()
            => new StripeValidator();

    }
}
