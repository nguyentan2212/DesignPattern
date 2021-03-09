using System;
using DesignPattern.CreationalPatterns.Singleton;
using DesignPattern.CreationalPatterns.FactoryMethod;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            // simple singleton pattern test
            SimpleSingletonExample simpleSingletonExample = new SimpleSingletonExample();
            simpleSingletonExample.Run();

            // thread - safe singleton pattern test
            ThreadSafeSingletonExample threadSafeSingletonExample = new ThreadSafeSingletonExample();
            threadSafeSingletonExample.Run();

            // factory method pattern test
            FactoryMethodExample factoryMethodExample = new FactoryMethodExample();
            factoryMethodExample.Run();
        }
    }
}
