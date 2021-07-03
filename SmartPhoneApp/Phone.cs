using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPhoneApp
{
    public class Phone :IPhone
    {
        public void Hangup()
        {
            Console.WriteLine("hangup");
        }

        public void Release()
        {
            Console.WriteLine("release");
        }
    }
}
