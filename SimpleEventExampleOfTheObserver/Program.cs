using System;

namespace ObserverEventsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Product myProduct = new Product();
            myProduct.OnStateChange += newState => Console.WriteLine("State changed to " + newState);
            myProduct.MyState = State.State3;

            Console.ReadKey();
        }
    }
}
