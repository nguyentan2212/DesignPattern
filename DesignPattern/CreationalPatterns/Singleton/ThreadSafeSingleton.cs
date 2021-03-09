namespace DesignPattern.CreationalPatterns.Singleton
{
    public class ThreadSafeSingleton
    {
        private ThreadSafeSingleton()
        {

        }
        public string Value { get; private set; }
        private static readonly object _lock = new object();
        private static ThreadSafeSingleton instance;
        public static ThreadSafeSingleton GetInstance(string value)
        {
            if (instance == null)
            {
                lock (_lock)
                {
                    if (instance == null)
                    {
                        instance = new ThreadSafeSingleton();
                        instance.Value = value;
                    }
                }
            }
            return instance;
        }
    }
}
