using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Pattern_Exercise
{
    class Motorcycle : IDrivable
    {
        public void Drive()
        {
            Console.WriteLine("Rippin a wheelie on my hog");
        }
    }
}
