using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProlabWithFP
{
    public class Reservation
    {
        public Passenger Passenger { get; set; }
        public string arrival { get; set; }
        public string departure { get; set; }
        public int price { get; set; } 
        public Reservation(Passenger passenger,string arrival,string departure,int price) {
            this.Passenger = passenger;
            this.arrival = arrival;
            this.departure = departure;
            this.price = price;
        }
        
    }
}
