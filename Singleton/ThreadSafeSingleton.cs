using System;
using System.Threading;

namespace Singleton
{
    public class ThreadSafeSingleton
    {
        private ThreadSafeSingleton()
        {
            
        }
        public string Value { get; set; }
        private static ThreadSafeSingleton instance;
        private static readonly object _lock = new object();
        public static ThreadSafeSingleton GetInstance(string value)
        {
            if (instance == null)
            {
                lock(_lock)
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