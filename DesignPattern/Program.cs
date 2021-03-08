using System;
using Singleton.Tests;
namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // simple singleton pattern test
            SimpleSingletonTest simpleSingletonTest = new SimpleSingletonTest();
            simpleSingletonTest.Test();

            // thread-safe singleton pattern test
            ThreadSafeSingletonTest threadSafeSingletonTest = new ThreadSafeSingletonTest();
            threadSafeSingletonTest.Test();
        }
    }
}
