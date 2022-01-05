using System;

namespace Week2Day3Demos.PolymorphicExample
{
    class PolymorphicVehicle
    {
        protected int speed = 0;
        public void Start()
        {
            Console.WriteLine("Vehicle Start");
        }

        public void Stop()
        {
            speed = 0;
            Console.WriteLine("Vehicle Stop");
        }

        public void Accelerate()
        {
            speed += 10;
            Console.WriteLine("Vehicle Accelerate");
        }

        public void Brake()
        {
            speed -= 10;
            Console.WriteLine("Vehicle Brake");
        }

        public int GetSpeed()
        {
            return speed;
        }
    }
}
