using AbstractFactoryApp;
using AbstractFactoryApp.Interfaces;
using AbstractFactoryApp.MercadoPago;
using AbstractFactoryApp.PagSeguro;
using AbstractFactoryApp.Stripe;

Console.WriteLine("=== Sistema de Pagamentos ===\n");

#region _MERCADO PAGO_
IPaymentFactory mercadoPagoFactory = new MercadoPagoGateway();

IPaymentService mercadoPagoService = new PaymentService(mercadoPagoFactory);
mercadoPagoService.ProcessPayment(200.00m, "5234567890123456");
#endregion

#region _PAGSEGURO_
IPaymentFactory pagSeguroFactory = new PagSeguroGateway();

IPaymentService pagSeguroService = new PaymentService(pagSeguroFactory);
pagSeguroService.ProcessPayment(150.00m, "1234567890123456");
#endregion

#region _STRIPE_
IPaymentFactory stripeFactory = new StripeGateway();

IPaymentService stripeService = new PaymentService(stripeFactory);
stripeService.ProcessPayment(100.00m, "4234567890123456"); 
#endregion
