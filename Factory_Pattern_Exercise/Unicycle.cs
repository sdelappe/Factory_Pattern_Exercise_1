using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Pattern_Exercise
{
    class Unicycle : IDrivable
    {
        public void Drive()
        {
            Console.WriteLine("Driving a nice unicycle");
        }
    }
}
