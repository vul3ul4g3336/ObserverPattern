using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public interface ISubject
    {
        void RegisterObserver(AObserver pObserver);
        void RemoveObserver(AObserver pObserver);
        void notifyObservers(string pContent);
    }
}
