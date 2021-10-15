using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Pattern_Exercise
{

    static class VehicleFactory
    {
        public static IDrivable GetVehicle(int numOfTires)
        {
            switch (numOfTires)
            {
                case 1:
                    return new Unicycle();
                    break;

                case 2:
                    return new Motorcycle();
                    break;
                default:
                    return new Car();

            }
        }
    }
}
