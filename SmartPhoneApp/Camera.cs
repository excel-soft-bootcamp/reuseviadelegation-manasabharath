using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPhoneApp
{
    public class Camera:ICamera
    {
        public void Click()
        {
            Console.WriteLine("Image");
        }
    }
}
