using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloWorld
{
    class filestreamEx
    {
        public void fileEx()
        {
            string[] names = new string[] { "DineshKumar", "PraveenKumar" };

            using (StreamWriter sw = new StreamWriter("names.txt"))
            {

                foreach (string s in names)
                {
                    sw.WriteLine(s);
                }
            }

            // Read and show each line from the file.
            string line = "";
            using (StreamReader sr = new StreamReader("names.txt"))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            Console.ReadKey();
        }
    }
}
