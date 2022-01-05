using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day3Demos.PolymorphicExample
{
    class PolymorphicCar : PolymorphicVehicle
    {
        public void OpenSunRoof()
        {
            Console.WriteLine("Car Open Sun Roof");
        }

        public void CloseSunRoof()
        {
            Console.WriteLine("Car Close Sun Roof");
        }
    }

    class PolymorphicElectricCar : PolymorphicCar
    {
        public void Charge()
        {
            Console.WriteLine("Electric Car charge");
        }

        // We are overwriting the default 
        // OOP Term: Method OverRiding
        //     Note: This is different to Method OverLoading
        public override void Accelerate()
        {
            speed += 30;
            Console.WriteLine("ElectricCar Accelerate");
        }
    }

    internal class PolymorphicDemo
    {
        public static void Test()
        {
            Console.WriteLine("---------------------------------");
            // What is the output of the below code. Answer given below!
            PolymorphicCar c = new PolymorphicCar();
            c.Accelerate();
            Console.WriteLine($"1.speed = {c.GetSpeed()}");  //10

            PolymorphicElectricCar e = new PolymorphicElectricCar();
            e.Accelerate();
            e.Accelerate();
            Console.WriteLine($"2.speed = {e.GetSpeed()}");  // 60

            Console.WriteLine("---------------------------------");

            // What is the output of the below code.
            // Find out and explain why.
            PolymorphicCar car;
            car = new PolymorphicCar();
            car.Accelerate();
            Console.WriteLine($"3.speed = {car.GetSpeed()}"); // 10

            car = new PolymorphicElectricCar();
            car.Accelerate();
            car.Accelerate();
            Console.WriteLine($"4.speed = {car.GetSpeed()}"); // 20
            Console.WriteLine("---------------------------------");
        }
    }
}
