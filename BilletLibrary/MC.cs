using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    public class Mc : Vehicle
    {

        public Mc()
        {
            
        }

        public override decimal Price()
        {
            return 125;
        }

        public override string VehicleType()
        {
            return "MC";
        }


    }
}
