using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProlabWithFP
{
    public class Road
    {
        public List<City> roadway = new List<City>();
        public List<string> roadwayString = new List<string>();

        public List<City> reversedRoadway = new List<City>();
        public List<string> reversedRoadwayString = new List<string>();


        public List<List<City>> cityComb = new List<List<City>>();
        public List<List<City>> cityCombReversed = new List<List<City>>();

        public Road(params City[] cities)
        {
            this.bindCities(cities);
            this.findCombinations(roadway);
        }

        public Road(List<City> cities)
        {
            this.bindCities(cities);
            this.findCombinations(roadway);
        }


        public void bindCities(City[] cities)
        {
            foreach (City c in cities) {
                this.roadway.Add(c);
                this.roadwayString.Add(c.name);
            }
            List<City> list = new List<City>(this.roadway);
            list.Reverse();
            foreach (City c in list)
            {
                this.reversedRoadway.Add(c);
                this.reversedRoadwayString.Add(c.name);
            }
        }

        public void bindCities(List<City> cities)
        {
            foreach (City c in cities)
            {
                this.roadway.Add(c);
                this.roadwayString.Add(c.name);
            }
            List<City> list = new List<City>(this.roadway);
            list.Reverse();
            foreach (City c in list)
            {
                this.reversedRoadway.Add(c);
                this.reversedRoadwayString.Add(c.name);
            }
        }

        public void findCombinations(List<City> dataList)
        {
            int n = dataList.Count;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    List<City> list1 = new List<City>();
                    List<City> list2 = new List<City>();
                    list1.Add(dataList[i]);
                    list1.Add(dataList[j]);
                    list2.Add(dataList[j]);
                    list2.Add(dataList[i]);
                    cityComb.Add(list1);
                    cityCombReversed.Add(list2);

                }
            }

    }

        public int findIndex(City city,bool reversed)
        {
            int index = 0;
            if(reversed)
            {
                foreach (City c in reversedRoadway)
                {
                    if (city.name == c.name)
                    {
                        return index;
                    }
                    index++;
                }
                return -1;
            }
            foreach (City c in roadway)
            {
                if (city.name == c.name)
                {
                    return index;
                }
                index++;
            }
            return -1;

        }

        public override string ToString()
        {
            string maintext = "";
            foreach(string text in roadwayString)
            {
                maintext += text + " ";
            }
            maintext += "-- ";
            foreach (string text in reversedRoadwayString)
            {
                maintext += text + " ";
            }
            return maintext;
        }



    }
}
