using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
     class Html_notification : Itype_Notification
    {
        public void Convert_to_required_format() 
        {
            Console.WriteLine("Converting to HTML...");
        }
        public void Sending()
        {
            Console.WriteLine("Sending HTML...");
        }

    }
}
