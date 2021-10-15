using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Pattern_Exercise
{
    class Car : IDrivable
    {
        public void Drive()
        {
            Console.WriteLine("Driving a car");
        }
    }
}
