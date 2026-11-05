using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace observer
{
    public abstract class Notification
    {
        private TipoNoti _noti;
        public TipoNoti noti
        {
            get { return _noti; }
            set { _noti = value; }
        }
        
        public abstract void Notify(TipoNoti noti);    
    }
}