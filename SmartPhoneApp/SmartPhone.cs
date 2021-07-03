using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPhoneApp
{
    public class SmartPhone:ICamera,IGps,IPhone
    {
        
            ICamera cameraref;
            IGps gpsref;
            IPhone phoneref;

            public void SetCamera(ICamera _camera)
            {
                this.cameraref = _camera;
            }
            public void SetGps(IGps _gps)
            {
                this.gpsref = _gps;
            }
            public void SetPhone(IPhone _phone)
            {
                this.phoneref = _phone;
            }
            public void Click()
            {
                this.cameraref.Click();
            }
            public void Navigate()
            {
                 this.gpsref.Navigate();
            }
          public void Hangup()
            {
                this.phoneref.Hangup();
            }
            public void Release()
            {
                this.phoneref.Release();
            }
            
        }
}
