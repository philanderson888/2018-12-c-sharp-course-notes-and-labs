using System;

namespace Pass_By_Reference
{
    class Program
    {
        static void Main(string[] args)
        {           
            var c = new Car("blue",0);

            Console.WriteLine("Car speed is {0}",c.speed);
            Accelerate(c);
            Console.WriteLine("After acceleration, car speed is {0}", c.speed);
        }

        static void Accelerate(Car car)
        {
            // increase the speed of the car
            car.speed++;
        }
    }

    class Car
    {
        public string color { get; set; }
        public int speed { get; set; }
        public Car(string color, int speed)
        {
            this.color = color;
            this.speed = speed;
        }
    }
}
