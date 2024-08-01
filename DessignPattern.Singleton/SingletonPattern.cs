namespace DessignPattern.Singleton
{
    public class SingletonPattern
    {
        private readonly static SingletonPattern _instance = new SingletonPattern();

        public static SingletonPattern Instance
        {
            get { return _instance; }
        }

        private SingletonPattern() { }
    }
}
