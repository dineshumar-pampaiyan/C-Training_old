using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloWorld
{
    //example for operators
    class operators
    {
        //arithmetic Operators
        public void arithmeticOperators()
        {
            int a, b, c;
            Console.WriteLine("*********Arithmetic Operators**************\n");
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

        //relational operators
        public void relationalOperators()
        {
            int a, b;

            Console.WriteLine("*********Relational Operators**************\n");
            Console.WriteLine("Enter The Two Numbers To Perform a Relational Opearations:\n");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            if (a == b)
            {
                Console.WriteLine("a is equal to b\n");
            }

            if(a < b)
            {
                Console.WriteLine("a is less than b\n");
            }

            if (a > b)
            {
                Console.WriteLine("a is greater than b\n");
            }

            if (a >= b)
            {
                Console.WriteLine("a is Greater than or equal to b\n");
            }
            
            if (a <= b)
            {
                Console.WriteLine("a is Less than or equal to b\n");
            }
            Console.ReadLine();
        }
    }
}
