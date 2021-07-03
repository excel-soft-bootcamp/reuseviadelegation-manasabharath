using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPhoneApp
{
    public class Person : Phone
    {
        public void Communicate()
        {
            Phone _phone = new Phone();
            _phone.Hangup();
            _phone.Release();
        }
    }
}
