using System;

namespace helloWorld
{
    public delegate string MyDel(string str);

    class events
    {
        event MyDel MyEvent;
        public events()
        {
            this.MyEvent += new MyDel(this.WelcomeUser);
        }
        public string WelcomeUser(string username)
        {
            return "Welcome " + username;
        }
        public void eventExamples()
        {
            Console.WriteLine("*****Events*****");
            events obj1 = new events();
            string result = obj1.MyEvent("DineshKumar");
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
