using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProlabWithFP
{
    public class Company : User, IProfitable
    {

        public string name;

        public static ArrayList Companies = new ArrayList();

        public ArrayList busList = new ArrayList();
        public ArrayList airplaneList = new ArrayList();
        public ArrayList trainList = new ArrayList();

        public List<Road> newBusRoads = new List<Road>();
        public List<Road> newTrainRoads = new List<Road>();
        public List<Road> newAirplaneRoads = new List<Road>();
        public List<Transport> currentTickets = new List<Transport>();

        public Company(string username, string password, string name)
        {
            this.username = username;
            this.password = password;
            this.name = name;
            newAirplaneRoads.Add(new Road(new City("İstanbul"), new City("Ankara")));
            newAirplaneRoads.Add(new Road(new City("İstanbul"), new City("Konya")));
        }

        public static void addNewCompany(Company company)
        {
           Companies.Add(company);
        }

        public void addNewBus(Bus bus)
        {
            busList.Add(bus);
        }
        public void addNewTrain(Train train)
        {
            trainList.Add(train);
        }
        public void addNewAirplane(Airplane airplane)
        {
            airplaneList.Add(airplane);
        }
        public static Company searchCompany(string companyName)
        {
            foreach(Company company in Companies)
            {
                if(company.name==companyName)
                {
                    return company;
                }
            }
            return null;
        }
        
        public Bus searchBus(string busName)
        {
            foreach(Bus b in busList)
            {
                if(b.name==busName)
                {
                    return b;
                }
            }
            return null;
        }
        public Airplane searchAirplane(string airplaneName)
        {
            foreach (Airplane a in airplaneList)
            {
                if (a.name == airplaneName)
                {
                    return a;
                }
            }
            return null;
        }
        public Train searchTrain(string trainName)
        {
            foreach (Train t in trainList)
            {
                if (t.name == trainName)
                {
                    return t;
                }
            }
            return null;
        }

        public void calculateProfit(out int dailyCost,out int weeklyCost,out int totalEarnings,out int totalProfit)
        {
            dailyCost = 0;

            weeklyCost = 0;
            totalEarnings = 0;
            totalProfit = 0;

            int tempDriverPrice = 0;
            int tempServicerPrice = 0;
            int tempFuelCost = 0;

            int servicePay = AdminPanel.pay;

            foreach (Bus bus in this.busList)
            {
                tempDriverPrice = 2 * bus.driver.salary * 2;
                tempServicerPrice = 2 * bus.servicer.salary * 2;
                tempFuelCost = bus.fuel_cost;
                dailyCost = dailyCost + tempDriverPrice + tempServicerPrice + tempFuelCost;

            }

            foreach (Airplane airplane in this.airplaneList)
            {
                ;
                tempDriverPrice = 2 * airplane.driver.salary * 2;
                tempServicerPrice = 2 * airplane.servicer.salary * 2;
                tempFuelCost = airplane.fuel_cost;
                dailyCost = dailyCost + tempDriverPrice + tempServicerPrice + tempFuelCost;
            }

            foreach (Train train in this.trainList)
            {
                tempDriverPrice = 2 * train.driver.salary * 2;
                tempServicerPrice = 2 * train.servicer.salary * 2;
                tempFuelCost = train.fuel_cost;
                dailyCost = dailyCost + tempDriverPrice + tempServicerPrice + tempFuelCost;
            }

            foreach (Transport ts in this.currentTickets)
            {
                totalEarnings += ts.customer.totalTicketCost;
            }

            dailyCost += servicePay;
            weeklyCost = dailyCost * 7;
            totalProfit = totalEarnings - weeklyCost/7;
        }

    }
}
