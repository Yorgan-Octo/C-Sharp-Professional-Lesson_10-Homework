using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{

    public abstract class PaymentSystem
    {
        public void Transaction()
        {
            Console.WriteLine("Creating transaction");
            CoreTransaction();
            Console.WriteLine("Committing transaction");
        }

        protected abstract void CoreTransaction();
    }

    public class Customer : PaymentSystem
    {
        public string Name { get; set; } = "Jon";
        public decimal Credit { get; set; } = 456;

        protected override void CoreTransaction()
        {
            Console.WriteLine($"Transaction customer {Name} with credit limit {Credit}");
        }
    }

    internal class Program
    {
        static void Main()
        {

            Customer customer = new Customer();
            customer.Transaction();

            Console.ReadKey();
        }
    }
}
