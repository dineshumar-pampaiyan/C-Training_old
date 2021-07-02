using System;

namespace helloWorld
{
    class indexers
    {
        private string[] namelist = new string[size];
        static public int size = 10;

        public indexers()
        {
            for (int i = 0; i < size; i++)
                namelist[i] = "Not Available";
        }
        public string this[int index]
        {
            get
            {
                string tmp;

                if (index >= 0 && index <= size - 1)
                {
                    tmp = namelist[index];
                }
                else
                {
                    tmp = "";
                }

                return (tmp);
            }
            set
            {
                if (index >= 0 && index <= size - 1)
                {
                    namelist[index] = value;
                }
            }
        }

        public void indexerExample()
        {
            Console.WriteLine("*****Indexers*****");
            indexers names = new indexers();
            names[0] = "Dinesh";
            names[1] = "Kumar";
            names[2] = "Karthick";
            names[3] = "Raja";
            names[4] = "Ayyanar";
            names[5] = "Suriya";
            names[6] = "Prabhakar";

            for (int i = 0; i < indexers.size; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.ReadKey();
        }
    }
}
