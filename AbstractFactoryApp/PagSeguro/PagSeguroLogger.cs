using AbstractFactoryApp.Interfaces;

namespace AbstractFactoryApp.PagSeguro
{
    public class PagSeguroLogger : IPaymentLogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"[PagSeguro Log] {DateTime.Now}: {message}");
        }
    }
}
