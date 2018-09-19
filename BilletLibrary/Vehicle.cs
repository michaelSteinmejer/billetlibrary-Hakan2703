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
        public bool BroBizz { get; set; }

        private const int MaxLength = 7;
         
        
   
 
        public virtual decimal Price()
        {
            if ( BroBizz == true)
            {
                Pris = Pris * 105 / 100;

            }
            return Pris;
        }
        /// <summary>
        /// Dette er en virtual metode der kan overskrives, husk at kommentere din kode
        /// </summary>
        /// <returns></returns>
        public virtual string VehicleType() => "Vehicle";

         
    }
}
