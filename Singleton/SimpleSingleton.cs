using System;

namespace Singleton
{
    public class SimpleSingleton
    {
        private SimpleSingleton()
        {
            
        }
        private static SimpleSingleton instance;
        public static SimpleSingleton GetInstance()
        {
            if (instance == null)
            {
                instance = new SimpleSingleton();
            }
            return instance;
        }
    }
}
