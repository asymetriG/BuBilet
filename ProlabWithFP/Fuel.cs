using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProlabWithFP
{
    public class Fuel
    {
        public string fuel_type { get; set; }
        public int fuel_price { get; set; }

        public Fuel(string fuel_type, int fuel_price)
        {
            this.fuel_type = fuel_type;
            this.fuel_price = fuel_price;
        }
    }
}
