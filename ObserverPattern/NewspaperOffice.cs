using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    internal class NewspaperOffice : ISubject
    {
        static List<AObserver> lstObservers;
        public NewspaperOffice()
        {
            lstObservers = new List<AObserver>();
        }
        public void notifyObservers(string pContent)
        {
            foreach (AObserver observer in lstObservers)
            {
                observer.Update(pContent);
            }
        }

        public void RegisterObserver(AObserver pObserver)
        {
            lstObservers.Add(pObserver);
        }

        public void RemoveObserver(AObserver pObserver)
        {
            if (lstObservers.Contains(pObserver))
                lstObservers.Remove(pObserver);
        }
        public void SubscribeNewspaper(AObserver pCustomer)
        {
            RegisterObserver(pCustomer);
        }

        // 取消訂閱報紙
        public void UnsubscribeNewspaper(AObserver pCustomer)
        {
            RemoveObserver(pCustomer);
        }

        // 發送新消息
        public void SendNewspaper(string pContent)
        {
            Console.WriteLine("Send News..");
            notifyObservers(pContent);
        }



        /// <summary>
        /// 發生於當用戶接收到報社寄來的報紙的時候
        /// </summary>
        /// <param name="office"></param>
        /// <param name="customer"></param>
        /// <returns></returns>
        public static NewspaperOffice operator +(NewspaperOffice office, Customer customer)
        {
            lstObservers.Add(customer);
            return office;
        }
    }
}
