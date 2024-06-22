using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProlabWithFP
{
    public class Trip
    {
        public Route route { get; set; }

        public int price { get; set; }

        public void calculatePrice()
        {
            if(route.wayType.Equals("roadway"))
            {
                if(route.distance==100)
                {
                    price = 50;
                }
                else if(route.distance==200)
                {
                    price = 100;
                }
                else if(route.distance==300)
                {
                    price = 150;
                }
                else if (route.distance == 400)
                {
                    price = 200;
                }
                else if (route.distance == 500)
                {
                    price = 250;
                }
                else if(route.distance==600)
                {
                    price = 300;
                }
            }
            else if(route.wayType.Equals("railway"))
            {
                if (route.distance == 75)
                {
                    price = 50;
                }
                else if (route.distance == 150)
                {
                    price = 100;
                }
                else if (route.distance == 225)
                {
                    price = 150;    
                }
                else if (route.distance == 300)
                {
                    price = 200;
                }
                else if (route.distance == 350)
                {
                    price = 250;
                }
                else if (route.distance == 375)
                {
                    price = 250;
                }
                else if (route.distance == 450)
                {
                    price = 300;
                }
            }
            else if (route.wayType.Equals("airway"))
            {
                if (route.distance == 250)
                {
                    price = 1000;
                }
                else if (route.distance == 300)
                {
                    price = 1200;
                }
            }
        }

        public Trip(Route route)
        {
            this.route = route;
            this.calculatePrice();
        }
        

    }
}
