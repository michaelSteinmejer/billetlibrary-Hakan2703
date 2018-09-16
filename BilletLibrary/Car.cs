using System;

namespace BilletLibrary
{
    public class Car : Vehicle
    {
        /// <summary>
        /// This is a class of a car that we need in order to have a price for this kind og vehicle in our ticket sistem
        /// </summary>
        public Car()
        {
            
        }

        public override decimal Price()
        {
            return 240;
        }

        public override string VehicleType()
        {
            return "Bil";
        }

        

    }
}
