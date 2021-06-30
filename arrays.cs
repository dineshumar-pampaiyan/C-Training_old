using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloWorld
{
    //example for array
    class arrays
    {
        public void simpleArrayExample()
        {
            Console.WriteLine("******Arrays******");
            //declaration and initialization of array
            int[] n = new int[10];

            //initialize elements of array
            for (int i = 0; i < 10; i++)
            {
                n[i] = i + 1000;
            }

            //Output each array elements value using forEach
            foreach (int j in n)
            {
                int i = j - 1000;
                Console.WriteLine("Elements[{0}] = {1}", i, j);
            }
            Console.ReadKey();
        }

        public void multiDimensionalArra()
        {
            //multi dimensional array
            int[,] a = new int[4, 3] { { 0, 0, 0 }, { 1, 2, 1 }, { 2, 4, 3 }, { 3, 6, 5 } };
            int i, j;

            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.WriteLine("a[{0},{1}] = {2}", i, j, a[i, j]);
                }
            }
            Console.ReadLine();
        }

        public void jaggedArray()
        {
            //a jagged array of 5 array of integers
            int[][] a = new int[][]{new int[]{0,0},new int[]{1,2},
            new int[]{2,4},new int[]{ 3, 6 }, new int[]{ 4, 8 } };
            int i, j;

            // output each array element's value 
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.WriteLine("a[{0}][{1}] = {2}", i, j, a[i][j]);
                }
            }
            Console.ReadKey();
        }

        public void arrayClass()
        {
            int[] list = { 25, 87, 8, 57, 24, 20, 10 };
            int[] temp = list;
            Console.Write("Original Array: ");

            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            // reverse the array
            Array.Reverse(temp);
            Console.Write("Reversed Array: ");

            foreach (int i in temp)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //sort the array
            Array.Sort(list);
            Console.Write("Sorted Array: ");

            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
