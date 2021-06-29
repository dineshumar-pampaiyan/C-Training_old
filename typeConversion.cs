using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloWorld
{
    public class typeConversion
    {
        public void typeCast()
        {
            double d = 6.456;
            bool b = true;
            float f = 1.54f;
            int i;

            //cast float to integer explicit conversion
            i = (int)d;
            Console.WriteLine(i);

            //cast various dataTypes to string
            Console.WriteLine(b.ToString());
            Console.WriteLine(d.ToString());
            Console.WriteLine(f.ToString());
        }
    }
}
