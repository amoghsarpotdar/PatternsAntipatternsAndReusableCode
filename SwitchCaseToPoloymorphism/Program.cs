using System;

namespace SwitchCaseToPoloymorphism
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Using polymorphism is better than using switch case logic to structure your logic.");
            Console.ReadKey();
            TheSwitchCaseLogicVehicleImplementation v1 = new TheSwitchCaseLogicVehicleImplementation(VehicleType.Bus);
            v1.Refuel(50);
            v1.TravelDistance(200);
            Console.ReadKey();

            Console.WriteLine("Working with poloymorphic objects...");
            Vehicle audi = new Car();
            audi.Refuel(40);
            audi.TravelDistance(400);
            Console.ReadKey();

            //Notice that code trying to access both type of object structures does not look much difference.
            //The differences are inside the implementation. In switch case structure the logic can quickly
            //get clumsy because it is concentrated in single location. It can become a maintenance nightmare
            //if switch case branching goes through large number of variations. With polymorphism testing
            //individual logical flows becomes a lot easier.
            
        }
    }
}
