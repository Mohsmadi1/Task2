using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Car
    {
        public string typeOfCar;
        public string modelOfCar;
        public string year;
        public string Color;
        public Engine engine;
        public void PrintCarInformation()
        {
            Console.WriteLine(this.typeOfCar);
            Console.WriteLine(this.modelOfCar);
            Console.WriteLine(this.year);
            Console.WriteLine(this.Color);
            this.engine.PrintEngineInformation();
        }
    }
}