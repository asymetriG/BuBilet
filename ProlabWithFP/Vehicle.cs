using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProlabWithFP
{
    public abstract class Vehicle
    {
        public abstract void CalculateFuelCost();
        public string name { get; set; }

        public Dictionary<List<string>, List<int>> seats = new Dictionary<List<string>, List<int>>();
        public Dictionary<List<string>, List<int>> reversedSeats = new Dictionary<List<string>, List<int>>();
        public Dictionary<string, Dictionary<List<string>, List<int>>> dailySeats = new Dictionary<string, Dictionary<List<string>, List<int>>>();
        public Dictionary<string, Dictionary<List<string>, List<int>>> reversedDailySeats = new Dictionary<string, Dictionary<List<string>, List<int>>>();
        public List<List<string>> cb;
        public abstract List<List<string>> FindCombinations(List<string> dataList);
        public abstract void init();

        public static int getID()
        {
            Random random = new Random();
            return random.Next(10000000,99999999);
        }

        public int fuel_cost { get; set; }
        public Fuel fuel { get; set; }
        public Route route { get; set; }
        public Road road { get; set; } 
        public int seat_count { get; set; }
        public Personel driver { get; set; }
        public Personel servicer { get; set; }



    }
}
