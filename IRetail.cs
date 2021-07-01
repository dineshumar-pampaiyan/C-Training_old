using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloWorld
{
    public interface IRetail
    {
        void showTransaction();
        double getAmount();
    }

    public class Retail : IRetail
    {
        private string transactionCode;
        private string date;
        private double transactionAmount;

        public Retail()
        {
            transactionCode = "";
            date = "";
            transactionAmount = 0.0;
        }

        public Retail(string tC, string d, double tA)
        {
            transactionCode = tC;
            date = d;
            transactionAmount = tA;
        }
        public double getAmount()
        {
            return transactionAmount;
        }

        public void showTransaction()
        {
            Console.WriteLine("Transaction: {0}", transactionCode);
            Console.WriteLine("Date: {0}", date);
            Console.WriteLine("Amount: {0}", getAmount());
        }
    }

    public class interfaceExample
    {
        public void iExample()
        {
            Retail r1 = new Retail("001", "8/10/2012", 78900.00);
            Retail r2 = new Retail("002", "9/10/2012", 451900.00);
            r1.showTransaction();
            r2.showTransaction();
            Console.ReadKey();
        }
    }
}
