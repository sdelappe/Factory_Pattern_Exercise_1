using System;

namespace Factory_Pattern_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many tires does your vehicle have: ");
            int numOfTires = Int32.Parse(Console.ReadLine());

            IDrivable vehicle = VehicleFactory.GetVehicle(numOfTires);
            vehicle.Drive();
        }
    }
}
