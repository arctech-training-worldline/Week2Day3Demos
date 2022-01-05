using System;

namespace Week2Day3Demos
{
    // Navneet, Shivasaran
    class RaceTrack
    {
        public void Test()
        {
            // This is the correct way to use the interface
            //IBike bike;
            //bike = new DummyBike();
            //bike = new CbzBike();

            // This is done just for training demo, refer above for correct way
            //DummyBike bike = new DummyBike();
            CbzBike bike = new CbzBike();
            bike.Start();
            
            bike.Accelerate(10);
            Console.WriteLine($"Bike speed = {bike.GetCurrentSpeed()}");
            bike.Refuel();
        }
    }
}
