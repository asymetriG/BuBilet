using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProlabWithFP
{
    public class Route
    {
        public City departure { get; set; }
        public City arrival { get; set; }

        private City Istanbul = new City("İstanbul");   
        private City Ankara = new City("Ankara");
        private City Bilecik = new City("Bilecik");
        private City Eskisehir = new City("Eskişehir");
        private City Konya = new City("Konya");
        private City Kocaeli = new City("Kocaeli");

        public City[] cities = new City[2];
        public int distance { get; set; }

        public string wayType = "roadway";

        private void bindCities()
        {
            cities[0] = departure; cities[1] = arrival;
        }

        private bool hasBothCities(City city1,City city2)
        {
            if ((cities[0].name.Equals(city1.name) && cities[1].name.Equals(city2.name)) || (cities[0].name.Equals(city2.name) && cities[1].name.Equals(city1.name)))
            {
                return true;
            }
            return false;
        }

        private void calculateDistance()
        {
            if (wayType.Equals("roadway"))
            {
                if (hasBothCities(Istanbul, Kocaeli))
                {
                    distance = 100;
                }
                if (hasBothCities(Istanbul, Ankara))
                {
                    distance = 500;
                }
                if (hasBothCities(Istanbul, Eskisehir))
                {
                    distance = 300;
                }
                if (hasBothCities(Istanbul, Konya))
                {
                    distance = 600;
                }
                if (hasBothCities(Kocaeli, Ankara))
                {
                    distance = 400;
                }
                if (hasBothCities(Kocaeli, Eskisehir))
                {
                    distance = 200;
                }
                if (hasBothCities(Kocaeli, Konya))
                {
                    distance = 500;
                }
                if (hasBothCities(Konya, Eskisehir))
                {
                    distance = 300;
                }
            }
            else if (wayType.Equals("railway"))
            {
                if (hasBothCities(Istanbul, Kocaeli))
                {
                    distance = 75;
                }
                if (hasBothCities(Istanbul, Bilecik))
                {
                    distance = 225;
                }
                if (hasBothCities(Istanbul, Ankara))
                {
                    distance = 375;
                }
                if (hasBothCities(Istanbul, Eskisehir))
                {
                    distance = 300;
                }
                if (hasBothCities(Istanbul, Konya))
                {
                    distance = 450;
                }
                if (hasBothCities(Kocaeli, Bilecik))
                {
                    distance = 75;
                }
                if (hasBothCities(Kocaeli, Ankara))
                {
                    distance = 300;
                }
                if (hasBothCities(Kocaeli, Eskisehir))
                {
                    distance = 150;
                }
                if (hasBothCities(Kocaeli, Konya))
                {
                    distance = 350;
                }
                if (hasBothCities(Bilecik, Ankara))
                {
                    distance = 225;
                }
                if (hasBothCities(Bilecik, Eskisehir))
                {
                    distance = 75;
                }
                if (hasBothCities(Bilecik, Konya))
                {
                    distance = 300;
                }
                if (hasBothCities(Ankara, Eskisehir))
                {
                    distance = 150;
                }
                if (hasBothCities(Eskisehir, Konya))
                {
                    distance = 225;
                }
            }
            else if (wayType.Equals("airway"))
            {
                if (hasBothCities(Istanbul, Ankara))
                {
                    distance = 250;
                }
                if (hasBothCities(Istanbul, Konya))
                {
                    distance = 300;
                }
            }
        }

        public Route(City departure,City arrival,string wayType) {
            this.departure = departure;
            this.arrival = arrival;
            this.wayType = wayType;

            this.bindCities();
            this.calculateDistance();
        }
        
    }
}
