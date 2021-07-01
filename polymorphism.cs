using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloWorld
{
    //polymorphism example functionOverloading **Static Polymorphism**
    class polymorphism
    {
        /*by changing number of parameters*/
        // adding two integer values.
        public int Add(int a, int b)
        {
            int sum = a + b;
            return sum;
        }

        // adding three integer values.
        public int Add(int a, int b, int c)
        {
            int sum = a + b + c;
            return sum;
        }

        /*by changing data type of parameters*/
        public double Add(double a, double b)
        {
            double sum = a + b;
            return sum;
        }

        public void functionOverloading()
        {
            Console.WriteLine("*****Polymorphism*****");
            polymorphism p = new polymorphism();

            int sum1 = p.Add(10, 20);
            Console.WriteLine("Sum Of the Two Integer Variables: {0} ", sum1);

            int sum2 = p.Add(20, 10, 30);
            Console.WriteLine("Sum Of the Three Integer Variables: {0}", sum2);

            double sum3 = p.Add(25.68, 78.24);
            Console.WriteLine("Sum of Two Double Variables:{0}", sum3);
            Console.ReadLine();
        }
    }
}
