using System;

namespace helloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //typeConversion type = new typeConversion();
            //type.typeCast();

            constants type = new constants();
            type.constant();

            operators op = new operators();
            op.arithmeticOperators();
        }
    }
}
