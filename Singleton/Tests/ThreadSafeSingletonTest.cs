using System;
using System.Threading;

namespace Singleton.Tests
{
    public class ThreadSafeSingletonTest
    {
        public ThreadSafeSingletonTest()
        {
            
        }
        public void Test()
        {
            Console.WriteLine();
            Console.WriteLine("---Thread-safe singleton test ----------------");
            Console.WriteLine(
                "{0}\n{1}\n{2}",
                "If you see the same value, then singleton was reused.",
                "If you see different values, then 2 singletons were created.",
                "RESULT:"
            );
            
            Thread process1 = new Thread(() =>
            {
                TestThreadSafeSingleton("ONE");
            });
            Thread process2 = new Thread(() =>
            {
                TestThreadSafeSingleton("TWO");
            });
            
            process1.Start();
            process2.Start();
            
            process1.Join();
            process2.Join();
        }
        private void TestThreadSafeSingleton(string value)
        {
            ThreadSafeSingleton singleton = ThreadSafeSingleton.GetInstance(value);
            Console.WriteLine(singleton.Value);
        } 
    }
}