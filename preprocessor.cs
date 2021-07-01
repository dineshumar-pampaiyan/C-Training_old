#define PI 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloWorld
{
    class preprocessor
    {
        public void preprocessorExample()
        {
        #if (PI)
            Console.WriteLine("PI is defined");
        #else
            Console.WriteLine("PI is not defined");
        #endif
            Console.ReadKey();
        }
    }
}
