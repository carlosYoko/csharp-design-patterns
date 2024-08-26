using DesignPattern.Strategy.Contracts;

namespace DesignPattern.Strategy
{
    public class Car : IStrategy
    {
        public void Run()
        {
            Console.WriteLine("Soy un coche y me estoy moviendo");
        }
    }
}
