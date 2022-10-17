using System.Security.Cryptography.X509Certificates;

internal class Program
{
    class Car
    {
        private int speed = 0;
        public void PrintSpeed()
        {
            if (speed == 0)
            {
                Console.WriteLine("Stay ...");
            }
            if (speed > 0)
            {
                Console.WriteLine($"Drive forward with speed {speed} km/h");
            }
            if (speed < 0)
            {
                Console.WriteLine($"Drive backward with speed {speed} km/h");
            }
        }
        public void DriveForward()
        {
            speed = 60;
        }
        public void Stop()
        {
            speed = 0;
        }
        public void DriveBackward()
        {
            speed = -5;
        }
    }
    private static void Main(string[] args)
    {
        Console.WriteLine("\t== Car 1 ==");
        var car = new Car();
        car.PrintSpeed();
        car.DriveForward();
        car.PrintSpeed();
        car.Stop();
        car.PrintSpeed();
        car.DriveBackward();
        car.PrintSpeed();

        Console.WriteLine("\t== Car 2 ==");
        var car2 = new Car();
        car2.PrintSpeed();
        car2.DriveBackward();
        car2.PrintSpeed();
    }
}