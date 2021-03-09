using System;

namespace DesignPattern.CreationalPatterns.Singleton
{
    public class SimpleSingletonExample
    {
        public SimpleSingletonExample()
        {

        }
        public void Run()
        {
            Console.WriteLine();
            Console.WriteLine("---Simple singleton test ----------------");
            SimpleSingleton s1 = SimpleSingleton.GetInstance();
            SimpleSingleton s2 = SimpleSingleton.GetInstance();

            if (s1 == s2)
            {
                Console.WriteLine("Singleton works, both variables contain the same instance.");
            }
            else
            {
                Console.WriteLine("Singleton failed, variables contain different instances.");
            }
        }
    }
}
