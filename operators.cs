using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloWorld
{
    class operators
    {
        public void arithmeticOperators()
        {
            int a, b, c;
            Console.WriteLine("Enter The Two Numbers To Perform a Arithmetic Opearations:\n");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            c = a + b;
            Console.WriteLine("Addition:  {0} + {1} = {2}\n", a, b, c);

            c = a - b;
            Console.WriteLine("Subtraction: {0} - {1} = {2}\n", a, b, c);

            c = a * b;
            Console.WriteLine("Multiplication: {0} * {1} = {2}\n", a, b, c);

            c = a / b;
            Console.WriteLine("Division: {0} / {1} = {2}\n", a, b, c);

            c = a % b;
            Console.WriteLine("Modulas: {0} % {1} = {2}\n", a, b, c);

            c = ++a;
            Console.WriteLine("Ingrement: ++a = {0}\n", c);

            c = --a;
            Console.WriteLine("Decrement: --a = {0}\n", c);
            Console.ReadLine();
        }
    }
}
