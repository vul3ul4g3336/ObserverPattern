using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    internal class Customer : AObserver
    {

        public Customer(string pName) : base(pName)
        {

        }

        public override void Update(string pMessage)
        {
            Console.WriteLine("   {0} receive a new message:{1}", MyName, pMessage);
        }
    }
}
