using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day3Demos
{
    internal class CbzBike : IBike, INitroBoosterBike
    {
        private int speed = 0;

        public void Start()
        {
            Console.WriteLine("Cbz Started");
        }

        public void Brake(int pressure)
        {
            speed = 0;
            Console.WriteLine("Cbz Brake");
        }

        public void Accelerate(int rate)
        {
            speed += rate;
            Console.WriteLine($"Cbz Accelerating at rate of {rate}");
        }
        public void Refuel()
        {
            Console.WriteLine("Cbz Refuelled");
        }
        public float GetCurrentSpeed()
        {
            return speed;
        }

        public void StartBoost()
        {
            
        }

        public void StopBoost()
        {
            throw new NotImplementedException();
        }
    }
}
