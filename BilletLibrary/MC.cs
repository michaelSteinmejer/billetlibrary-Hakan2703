using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    public class Mc
    {

        public Mc()
        {
            
        }


        public string Nummerplade { get; set; }
        public DateTime dato { get; set; }

        public decimal Price()
        {
            return 125;
        }

        public string vehicle()
        {
            return "MC";
        }


    }
}
