using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    public abstract class Vehicle
    {
        private string _nummerplade;

        public string Nummerplade
        {
            get => _nummerplade;
            set
            {
                if (value.Length > 7)
                {
                    throw new ArgumentException("Nummerpladen er for lang");
                }

                _nummerplade = value;
            }
        }

        public decimal Pris { get; set; }
        public DateTime Dato { get; set; }

        private const int MaxLength = 7;
         
   
 
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
