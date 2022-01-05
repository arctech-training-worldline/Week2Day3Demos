using System;

namespace Week2Day3Demos
{
    //Navneet, Shivasaran
    class DummyBike : IBike
    {
        private int speed = 0;

        public void Start()
        {
            Console.WriteLine("Started");
        }        

        public void Brake(int pressure)
        {
            speed = 0;
            Console.WriteLine("Brake");
        }

        public void Accelerate(int rate)
        {
            speed += rate;
            Console.WriteLine($"Accelerating at rate of {rate}");
        }
        public void Refuel()
        {
            Console.WriteLine("Refuelled");
        }
        public float GetCurrentSpeed()
        {            
            return speed;
        }
    }
}
