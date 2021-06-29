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

            if (a < b)
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

        //logical Operators
        public void logicalOperators()
        {
            bool a = true;
            bool b = true;

            Console.WriteLine("******Logical Operators********");

            if (a && b)
            {
                Console.WriteLine("a && b - Condition is true");
            }

            if (a || b)
            {
                Console.WriteLine("a || b - Condition is true");
            }

            /* lets change the value of  a and b */
            a = false;
            b = true;

            if (a && b)
            {
                Console.WriteLine("a && b - Condition is true");
            }
            else
            {
                Console.WriteLine("a && b - Condition is not true");
            }

            if (!(a && b))
            {
                Console.WriteLine("(!(a && b)) - Condition is true");
            }
            Console.ReadLine();
        }

        //Bitwise Operators
        public void bitwiseOperators()
        {
            int a = 60;            /* 60 = 0011 1100 */
            int b = 13;            /* 13 = 0000 1101 */
            int c = 0;

            Console.WriteLine("******Bitwise Operators********");

            c = a & b;             /* 12 = 0000 1100 */
            Console.WriteLine("a & b - Value of c is {0}", c);

            c = a | b;             /* 61 = 0011 1101 */
            Console.WriteLine("a | b - Value of c is {0}", c);

            c = a ^ b;             /* 49 = 0011 0001 */
            Console.WriteLine("a ^ b - Value of c is {0}", c);

            c = ~a;                /*-61 = 1100 0011 */
            Console.WriteLine("~a - Value of c is {0}", c);

            c = a << 2;      /* 240 = 1111 0000 */
            Console.WriteLine("a << 2 - Value of c is {0}", c);

            c = a >> 2;      /* 15 = 0000 1111 */
            Console.WriteLine("a >> 2 - Value of c is {0}", c);
            Console.ReadLine();
        }

        //Assignment Operators
        public void assignmentOperators()
        {
            int a = 10;
            int c;

            Console.WriteLine("******Assignment Operators********");

            c = a;
            Console.WriteLine("Value of c = {0}", c);

            c += a;
            Console.WriteLine("Value of c = {0}", c);

            c -= a;
            Console.WriteLine("Value of c = {0}", c);

            c *= a;
            Console.WriteLine("Value of c = {0}", c);

            c /= a;
            Console.WriteLine("Value of c = {0}", c);

            c = 20;
            c %= a;
            Console.WriteLine("Value of c = {0}", c);

            c <<= 2;
            Console.WriteLine("Value of c = {0}", c);

            c >>= 2;
            Console.WriteLine("Value of c = {0}", c);

            c &= 2;
            Console.WriteLine("Value of c = {0}", c);

            c ^= 2;
            Console.WriteLine("Value of c = {0}", c);

            c |= 2;
            Console.WriteLine("Value of c = {0}", c);
            Console.ReadLine();
        }
    }
}
