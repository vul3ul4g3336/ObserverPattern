using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NewspaperOffice office = new NewspaperOffice();
            Customer bob = new Customer("Bob");
            //office.SubscribeNewspaper(bob);
            int number = 10;
            number += 20; // number = number +20
            office += bob;

            Customer Dave = new Customer("Dave");
            office.SubscribeNewspaper(Dave);
            office.SendNewspaper("1.頭條新聞: ..");

            office.UnsubscribeNewspaper(Dave);
            office.SendNewspaper("頭條新聞:...");
            Console.ReadKey();
        }
    }
}
