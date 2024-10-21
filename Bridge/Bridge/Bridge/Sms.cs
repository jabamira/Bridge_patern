using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Sms : Notification
    {
        public Sms(Itype_Notification type) : base(type)
        {
        }
        public override void Notificatiob_is_sended()
        {

            Console.WriteLine("Sms is sended");
            Console.WriteLine("/////////////////");
        }
    }
}
