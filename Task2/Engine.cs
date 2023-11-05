using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Engine
    {
        public double horsepower;
        public bool isHybrid;

        public void PrintEngineInformation()
        {
            Console.WriteLine(this.horsepower);
            Console.WriteLine(this.isHybrid);
        }
    }
}
