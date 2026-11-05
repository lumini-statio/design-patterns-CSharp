using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace observer
{
    public class NotiApp : Notification
    {
        public NotiApp()
        {
        }
        public override void Notify(TipoNoti noti)
        {
            
            if(noti == TipoNoti.clases)
            {
                System.Console.WriteLine("mañana no ai clase");
            }
            else
            {
                System.Console.WriteLine("cagaste, se entregó el ecsamen");
            }
        }
    }
}