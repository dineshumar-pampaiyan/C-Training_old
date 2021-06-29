using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloWorld
{
    //Example program for constants
    class constants
    {
        public void constant()
        {
            const double pi = 3.14;
            double radius;
            Console.WriteLine("Enter Radius: ");
            radius = Convert.ToDouble(Console.ReadLine());

            double areaCircle = pi * radius * radius;
            Console.WriteLine("Radius: {0}, Area: {1}", radius, areaCircle);
            Console.ReadLine();
        }
    }
}
