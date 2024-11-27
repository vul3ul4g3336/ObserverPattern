using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public abstract class AObserver
    {
        public string MyName { get; set; }

        public AObserver(string pName)
        {
            MyName = pName;
        }

        // 更新最新消息
        public abstract void Update(string pMessage);

    }
}
