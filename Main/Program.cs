using System;
using Example.CreationalPatterns;

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
        }
    }
}
