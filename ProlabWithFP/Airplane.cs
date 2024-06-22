using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProlabWithFP
{
    public class Airplane : Vehicle
    {
        public int ID;
        public Airplane(int seat, Road road, string name, Personel driver, Personel servicer, Fuel fuel)
        {
            this.seat_count = seat;
            this.road = road;
            this.name = name;
            this.driver = driver;
            this.servicer = servicer;
            this.fuel = fuel;
            this.ID = getID();
            this.init();
        }

        public override void init()
        {
            cb = FindCombinations(road.roadwayString);
            foreach (List<string> list in cb)
            {
                List<int> temp = new List<int>();
                for (int i = 0; i < seat_count; i++)
                {
                    temp.Add(0);
                }
                seats.Add(list, temp);
            }

            cb = FindCombinations(road.reversedRoadwayString);
            foreach (List<string> list in cb)
            {
                List<int> temp = new List<int>();
                for (int i = 0; i < seat_count; i++)
                {
                    temp.Add(0);
                }
                reversedSeats.Add(list, temp);
            }


            dailySeats.Add("4 Aralık 2023", new Dictionary<List<string>, List<int>>(seats));
            dailySeats.Add("5 Aralık 2023", new Dictionary<List<string>, List<int>>(seats));
            dailySeats.Add("6 Aralık 2023", new Dictionary<List<string>, List<int>>(seats));
            dailySeats.Add("7 Aralık 2023", new Dictionary<List<string>, List<int>>(seats));
            dailySeats.Add("8 Aralık 2023", new Dictionary<List<string>, List<int>>(seats));
            dailySeats.Add("9 Aralık 2023", new Dictionary<List<string>, List<int>>(seats));
            dailySeats.Add("10 Aralık 2023", new Dictionary<List<string>, List<int>>(seats));

            reversedDailySeats.Add("4 Aralık 2023", new Dictionary<List<string>, List<int>>(reversedSeats));
            reversedDailySeats.Add("5 Aralık 2023", new Dictionary<List<string>, List<int>>(reversedSeats));
            reversedDailySeats.Add("6 Aralık 2023", new Dictionary<List<string>, List<int>>(reversedSeats));
            reversedDailySeats.Add("7 Aralık 2023", new Dictionary<List<string>, List<int>>(reversedSeats));
            reversedDailySeats.Add("8 Aralık 2023", new Dictionary<List<string>, List<int>>(reversedSeats));
            reversedDailySeats.Add("9 Aralık 2023", new Dictionary<List<string>, List<int>>(reversedSeats));
            reversedDailySeats.Add("10 Aralık 2023", new Dictionary<List<string>, List<int>>(reversedSeats));

            CalculateFuelCost();

        }

        public override List<List<string>> FindCombinations(List<string> dataList)
        {
            int n = dataList.Count;

            List<List<string>> cityComb = new List<List<string>>();

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    List<string> list = new List<string>
                    {
                        dataList[i],
                        dataList[j]
                    };
                    cityComb.Add(list);
                }
            }
            return cityComb;
        }

        public override void CalculateFuelCost()
        {
            route = new Route(road.roadway[0], road.roadway[road.roadway.Count - 1], "airway");
            fuel_cost = fuel.fuel_price * route.distance * 2;
        }
        public override string ToString()
        {
            return this.name;
        }


    }
}