namespace SwitchCaseToPoloymorphism
{
    class TheSwitchCaseLogicVehicleImplementation
    {
        private VehicleType _veichleType;
        public TheSwitchCaseLogicVehicleImplementation(VehicleType vehicletype)
        {
            _veichleType = vehicletype;
        }

        // ReSharper disable once UnusedAutoPropertyAccessor.Local
        public decimal FuelCapacityInLitres { get; private set; }

        public int MaxTravelingRange
        {
            // ReSharper disable once UnusedAutoPropertyAccessor.Local
            get; private set;
        }

        public void Refuel(int gallons)
        {
            if (gallons >= FuelCapacityInLitres)
                IsTheTankFull = true;
        }

        public bool IsTheTankFull { get; private set; }

        /// <summary>
        /// This is the moethod implementing switch-case structure
        /// to run some calculations specific to vehicle type. Instead of running
        /// such logical operations in a single method it makes sense to break this
        /// structure into polymorphic structure (Imagine what happens when we get
        /// 1000 different vehicles for which this logic is to be implemented).
        /// </summary>
        /// <param name="milesToTravel"></param>
        public void TravelDistance(int milesToTravel)
        {
            //Add some logic here to calculate fuel consumption per vehicletype
            switch (_veichleType)
            {
                case VehicleType.Car:
                    //Logic specific to car's fuel consumption, speed etc.
                    break;

                case VehicleType.Truck:
                    //Logic specific to truck's fuel consumption, speed etc.
                    break;

                case VehicleType.Aeroplane:
                    //Logic specific to aaeroplane's fuel consumption, speed etc.
                    break;

                case VehicleType.Bus:
                    //Logic specific to bus's fuel consumption, speed etc.
                    break;
            }
        }
    }

    enum VehicleType
    {
        Car,
        Truck,
        Bus,
        Aeroplane
    }
}
