namespace Week2Day3Demos
{
    // Me, Monika, Madhu, Akshay
    public interface IBike
    {
        void Start();
        void Brake(int pressure);   // pressure can be from 1 to 10
        void Accelerate(int rate);  // rate can be from 1 to 100
        void Refuel();
        float GetCurrentSpeed();
    }
}
