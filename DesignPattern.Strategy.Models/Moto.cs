using DesignPattern.Strategy.Contracts;

namespace DesignPattern.Strategy
{
    public class Moto : IStrategy
    {
        public void Run()
        {
            Console.WriteLine("Soy una moto y estoy en marcha");
        }
    }
}
