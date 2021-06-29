using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloWorld
{
    //example for loop
    class loop
    {
        //while loop
        public void whileLoop()
        {
            int a = 5;

            while (a < 10)
            {
                Console.WriteLine("value of a: {0}", a);
                a++;
            }
            Console.ReadLine();
        }

        public void forLoop()
        {
            for (int i = 10; i < 15; i++)
            {
                Console.WriteLine("value of i: {0}", i);
            }
        }

        public void dowhileLoop()
        {
            int a = 15;
            do
            {
                Console.WriteLine("value of a is:{0}", a);
                a++;
            } while (a < 20);
        }
    }
}
