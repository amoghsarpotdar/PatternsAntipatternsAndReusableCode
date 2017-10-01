using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCaseToPoloymorphism
{
    public abstract class Vehicle
    {
        private int _fuelCapacityInLitres;

        private int MaxTravellingRange;

        private bool IsTheTankFull = false;

        public virtual void Refuel(int gallons)
        {
            if (gallons >= _fuelCapacityInLitres)
                IsTheTankFull = true;
        }

        public virtual void TravelDistance(int milesToTravel)
        {
            //Default implementation goes here.
        }
    }

    public class Car : Vehicle
    {
        public override void Refuel(int gallons)
        {
            //Logic to car specific refuelling and fuel calculations goes here...
            Console.WriteLine("Refuelling car.");
            base.Refuel(gallons);
        }

        public override void TravelDistance(int milesToTravel)
        {
            //Logic to car specific fuel consumption goes here
            Console.WriteLine("Travelling in car to distance " + Convert.ToString(milesToTravel) + " miles.");
            base.TravelDistance(milesToTravel);
        }
    }

    public class Truck : Vehicle
    {
        public override void Refuel(int gallons)
        {
            //Logic to car specific refuelling and fuel calculations goes here...
            Console.WriteLine("Refuelling Truck");
            base.Refuel(gallons);
        }

        public override void TravelDistance(int milesToTravel)
        {
            //Logic to truck specific fuel consumption goes here
            Console.WriteLine("Travelling in truck distance " + Convert.ToString(milesToTravel) + " miles.");
            base.TravelDistance(milesToTravel);
        }
    }

    public class Bus : Vehicle
    {
        public override void Refuel(int gallons)
        {
            //Logic to bus specific refuelling and fuel calculations goes here...
            Console.WriteLine("Refuelling bus");
            base.Refuel(gallons);
        }

        public override void TravelDistance(int milesToTravel)
        {
            //Logic to bus specific fuel consumption goes here
            Console.WriteLine("Travelling in bus distance " + Convert.ToString(milesToTravel) + " miles.");
            base.TravelDistance(milesToTravel);
        }
    }

    public class Aeroplane : Vehicle
    {
        public override void Refuel(int gallons)
        {
            //Logic to aerpolane specific refuelling and fuel calculations goes here...
            Console.WriteLine("Refuelling Aeroplane");
            base.Refuel(gallons);
        }

        public override void TravelDistance(int milesToTravel)
        {
            //Logic to aeroplane specific fuel consumption goes here
            Console.WriteLine("Travelling in aeroplane distance " + Convert.ToString(milesToTravel) + " miles.");
            base.TravelDistance(milesToTravel);
        }
    }
}
