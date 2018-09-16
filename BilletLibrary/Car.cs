using System;

namespace BilletLibrary
{
    public class Car
    {
        /// <summary>
        /// This is a class of a car that we need in order to have a price for this kind og vehicle in our ticket sistem
        /// </summary>
        public Car()
        {
            
        }

        public string Nummerplade { get; set; }
        public DateTime Dato { get; set; }

        public decimal Price()
        {
            return 240;
        }

        public string Vehicle()
        {
            return "Car";
        }



    }
}
