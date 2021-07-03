using System;

namespace SmartPhoneApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Camera cameraref = new Camera();
            Gps gpsref = new Gps();
            Phone phoneref = new Phone();

            SmartPhone _smartphone = new SmartPhone();
            _smartphone.SetCamera(cameraref);
            _smartphone.SetGps(gpsref);
            _smartphone.SetPhone(phoneref);

            Photographer _photoGrapher = new Photographer();
            _photoGrapher.Capture(cameraref);
            _photoGrapher.Capture(_smartphone);
        }
    }
}
