using System;
using Singleton;

namespace Singleton.Tests
{
    public class SimpleSingletonTest
    {
        public SimpleSingletonTest()
        {
            
        }

        public void Test()
        {
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