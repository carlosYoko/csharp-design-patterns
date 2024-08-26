namespace DesignPattern.Strategy.Contracts
{
    public class Bicycle : IStrategy
    {
        public void Run()
        {
            Console.WriteLine("Soy una bici y voy a pedales");
        }
    }
}
