using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    abstract class Notification
    {
        protected Itype_Notification type;
        public Itype_Notification Type
        {
            set { type = value; }
        }

        public Notification(Itype_Notification Type)
        {
            type = Type;
        }
        public virtual void Send()
        {
            type.Convert_to_required_format();
            type.Sending();
        }
        public abstract void Notificatiob_is_sended();
    }
}
