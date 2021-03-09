namespace DesignPattern.CreationalPatterns.FactoryMethod
{
    public abstract class Creator
    {
        public abstract IProduct FactoryMethod();
        public string DoSomeOperation()
        {
            IProduct product = FactoryMethod();
            string result = "Creator: The same creator's code has just worked with " + product.Operation();
            return result;
        }
    }
}
