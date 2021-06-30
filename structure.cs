using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloWorld
{
    class structures
    {
        struct Car
        {
            public string Brand;
            public string color;
            public string model;
            public int price;
        }
        public void structureExamples()
        {
            Car car1;
            Car car2;

            Console.WriteLine("*****Structures*****");

            //Car 1 specifications
            car1.Brand = "RolsRoyce";
            car1.color = "Blue";
            car1.model = "2021";
            car1.price = 10000000;

            //Car2 Specification
            car2.Brand = "Audi";
            car2.color = "Blue";
            car2.model = "2021";
            car2.price = 1000000;

            //print car1 info
            Console.WriteLine("Car 1 Brand : {0}", car1.Brand);
            Console.WriteLine("Car 1 Color : {0}", car1.color);
            Console.WriteLine("Car 1 Model : {0}", car1.model);
            Console.WriteLine("Car 1 Price : {0}\n", car1.price);

            //print car2 info
            Console.WriteLine("Car 2 Brand : {0}", car2.Brand);
            Console.WriteLine("Car 2 Color : {0}", car2.color);
            Console.WriteLine("Car 2 Model : {0}", car2.model);
            Console.WriteLine("Car 2 Price : {0}", car2.price);

            Console.ReadKey();
        }   
    }
}

