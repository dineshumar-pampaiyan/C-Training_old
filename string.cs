using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloWorld
{
    class strings
    {
        public void stringOperations()
        {
            string firstName, lastName;
            firstName = "DineshKumar";
            lastName = "Pampaiyan";

            Console.WriteLine("********Strings*********");
            char[] welcome = { 'W', 'e', 'l', 'c', 'o', 'm', 'e' };
            string[] stringArray = { "welcome", "my", "Friend!" };

            string myName = firstName + lastName;
            Console.WriteLine("Full Name: {0}", myName);

            string greetings = new string(welcome);
            Console.WriteLine("Greetings: {0}", greetings);

            string message = String.Join("", stringArray);
            Console.WriteLine("Message:{0}", message);

            if (String.Compare(new string(welcome), greetings) == 0)
            {
                Console.WriteLine("given strings are equal.");
            }
            else
            {
                Console.WriteLine("given strings are not equal.");
            }
            Console.ReadLine();
        }

    }
}
