using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloWorld
{
    class callByRef
    {
        public void swap(ref int x, ref int y)
        {
            int temp;

            temp = x;
            x = y;
            y = temp;
        }

        public void callByReference()
        {
            callByRef c = new callByRef();
            int a = 100;
            int b = 200;

            Console.WriteLine("Before swap, value of a : {0}", a);
            Console.WriteLine("Before swap, value of b : {0}", b);

            /* calling a function to swap the values */
            c.swap(ref a, ref b);

            Console.WriteLine("After swap, value of a : {0}", a);
            Console.WriteLine("After swap, value of b : {0}", b);

            Console.ReadLine();
        }
    }
}
