using System.Drawing;

namespace Task2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.typeOfCar = "BMW";
            car1.modelOfCar = "BMW M5 F90";
            car1.year = "2022";
            car1.Color = "Black";
            car1.engine = new Engine
            {
                horsepower = 1000,
                isHybrid = false
            };

            Car car2 = new Car();
            car2.typeOfCar = "Nissan";
            car2.modelOfCar = "Nissan GTR R35";
            car2.year = "2023";
            car2.Color = "silver";
            car2.engine = new Engine
            {
                horsepower = 1200,
                isHybrid = false
            };

            Car car3 = new Car();
            car3.typeOfCar = "BMW";
            car3.modelOfCar = "BMW M8 Competition";
            car3.year = "2023";
            car3.Color = "Black";
            car3.engine = new Engine
            {
                horsepower = 865,
                isHybrid = false
            };

            List<Car> cars = new List<Car> { car1, car2, car3 };

            for (int i = 0; i < cars.Count; i++)
            {
                Car car = cars[i];
                car.PrintCarInformation();
                Console.WriteLine();
            }
        }
    }
}