using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.CreationalPatterns.FactoryMethod
{
    public class FactoryMethodExample
    {
        public void Run()
        {
            Console.WriteLine();
            Console.WriteLine("---Factory method test ----------------");
            Console.WriteLine("App: Launch with the ConcreteCreater1: ");
            ClientCode(new ConcreteCreator1());

            Console.WriteLine("App: Launch with the ConcreteCreater2: ");
            ClientCode(new ConcreteCreator2());
        }

        private void ClientCode(Creator creator)
        {
            Console.WriteLine("Client: I'm not aware of the creator's class, but it still works.\n" + creator.DoSomeOperation());
        }
    }
}
