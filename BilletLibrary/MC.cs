using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    class MC
    {

        public MC()
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
