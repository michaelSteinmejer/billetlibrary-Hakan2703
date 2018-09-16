using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    public abstract class Vehicle
    {

        public string Nummerplade { get; set; }
        public decimal Pris { get; set; }
        public DateTime Dato { get; set; }

        public virtual decimal Price()
        {
            return Pris;
        }

        public virtual string VehicleType()
        {
            return "Vehicle";
        }
    }
}
