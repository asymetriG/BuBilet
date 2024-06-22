using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProlabWithFP
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            City Istanbul = new City("İstanbul");
            City Ankara = new City("Ankara");
            City Bilecik = new City("Bilecik");
            City Eskisehir = new City("Eskişehir");
            City Konya = new City("Konya");
            City Kocaeli = new City("Kocaeli");

            List<City> cities = new List<City>
            {
                Istanbul,
                Ankara,
                Bilecik,
                Eskisehir,
                Konya,
                Kocaeli
            };

            Admin.realAdmin = new Admin("admin","admin");


            Bus bus1 = new Bus(20, new Road(Istanbul, Kocaeli, Ankara, Kocaeli),"Otobüs 1",new Personel("Crazy","Driver",5000), new Personel("Crazy", "Servicer", 2000), new Fuel("oil",10));
            Bus bus2 = new Bus(15, new Road(Istanbul, Kocaeli, Ankara, Kocaeli),"Otobüs 2", new Personel("Crazy", "Driver", 5000), new Personel("Crazy", "Servicer", 2000), new Fuel("oil",10));
            Company company1 = new Company("a", "a","A Firması");
            company1.addNewBus(bus1);
            company1.addNewBus(bus2);


            Bus bus3 = new Bus(20, new Road(Istanbul, Kocaeli, Ankara, Kocaeli), "Otobüs 1", new Personel("Crazy", "Driver", 3000), new Personel("Crazy", "Servicer", 1500), new Fuel("diesel", 10));
            Bus bus4 = new Bus(15, new Road(Istanbul, Kocaeli, Eskisehir, Konya), "Otobüs 2", new Personel("Crazy", "Driver", 3000), new Personel("Crazy", "Servicer", 1500), new Fuel("diesel", 5));
            Company company2 = new Company("b", "b","B Firması");
            company2.addNewBus(bus3);
            company2.addNewBus(bus4);


            Bus bus5 = new Bus(20, new Road(Istanbul, Kocaeli, Eskisehir, Konya), "Otobüs 1", new Personel("Crazy", "Driver", 4000), new Personel("Crazy", "Servicer", 2000), new Fuel("diesel", 6));
            Airplane airplane1 = new Airplane(30, new Road(Istanbul, Konya), "Uçak 1", new Personel("Crazy", "Driver", 10000), new Personel("Crazy", "Servicer", 6000), new Fuel("gas", 25));
            Airplane airplane2 = new Airplane(30, new Road(Istanbul, Konya), "Uçak 2", new Personel("Crazy", "Driver", 10000), new Personel("Crazy", "Servicer", 6000), new Fuel("oil", 10));
            Company company3 = new Company("c", "c", "C Firması");
            company3.addNewBus(bus5);
            company3.addNewAirplane(airplane1);
            company3.addNewAirplane(airplane2);


            Train train1 = new Train(25, new Road(Istanbul, Kocaeli, Bilecik, Eskisehir, Ankara), "Tren 1", new Personel("Crazy", "Driver", 2000), new Personel("Crazy", "Servicer", 1000), new Fuel("electric", 3));
            Train train2 = new Train(25, new Road(Istanbul, Kocaeli, Bilecik, Eskisehir, Konya), "Tren 2", new Personel("Crazy", "Driver", 2000), new Personel("Crazy", "Servicer", 1000), new Fuel("electric", 3));
            Train train3 = new Train(25, new Road(Istanbul, Kocaeli, Bilecik, Eskisehir, Konya), "Tren 3", new Personel("Crazy", "Driver", 2000), new Personel("Crazy", "Servicer", 1000), new Fuel("electric", 3));
            Company company4 = new Company("d", "d", "D Firması");
            company4.addNewTrain(train1);
            company4.addNewTrain(train2);
            company4.addNewTrain(train3);

            Airplane airplane3 = new Airplane(30, new Road(Istanbul, Ankara), "Uçak 1", new Personel("Crazy", "Driver", 7500), new Personel("Crazy", "Servicer", 4000), new Fuel("gas",20));
            Airplane airplane4 = new Airplane(30, new Road(Istanbul, Ankara), "Uçak 2", new Personel("Crazy", "Driver", 7500), new Personel("Crazy", "Servicer", 4000), new Fuel("gas",20));
            Company company5 = new Company("f", "f", "F Firması");
            company5.addNewAirplane(airplane3);
            company5.addNewAirplane(airplane4);

            Company.addNewCompany(company1);
            Company.addNewCompany(company2);
            Company.addNewCompany(company3);
            Company.addNewCompany(company4);
            Company.addNewCompany(company5);

            Random random = new Random();
            int index1;
            int index2;
            bool reversed = false;

            List<string> waytypes = new List<string>();
            List<string> vehicletypes = new List<string>();
            List<string> days = new List<string>();


            days.Add("4 Aralık 2023");
            days.Add("5 Aralık 2023");
            days.Add("6 Aralık 2023");
            days.Add("7 Aralık 2023");
            days.Add("8 Aralık 2023");
            days.Add("9 Aralık 2023");
            days.Add("10 Aralık 2023");

            City city1;
            City city2;

            int tripPrice = 0;
            int until1,until2;

            foreach(Bus b in company1.busList)
            {
                until1 = random.Next(1, 2);
                for (int i = 1;i<=b.seat_count;i+=until1)
                {
                    Trip trip;
                    Route route;

                    while (true)
                    {

                        while(true)
                        {
                            city1 = b.road.roadway[random.Next(0, b.road.roadway.Count)];
                            city2 = b.road.roadway[random.Next(0, b.road.roadway.Count)];

                            index1 = b.road.findIndex(city1, false);
                            index2 = b.road.findIndex(city2, false);

                            if(index1==-1 || index2==-1 || index1==index2)
                            {
                                continue;
                            }
                            break;
                        }
                        

                        if (index1 > index2)
                        {
                            reversed = true;
                        }
                        else
                        {
                            reversed = false;
                        }

                        route = new Route(city1, city2, "roadway");
                        trip = new Trip(route);
                        tripPrice = trip.price;

                        if(trip.price==0)
                        {
                            continue;
                        }
                        break;
                    }

                   
                    string day = days[random.Next(0, 7)];              

                    Transport ts = new Transport(trip, "Otobüs", route, company1, b, day); 
                    Customer customer = new Customer();
                    until2 = random.Next(0, 4);
                    List<int> newSeats = new List<int>();
                    int rand;
                    for(int j = 0;j< until2; j++)
                    {
                        rand = random.Next(1, b.seat_count);
                        Passenger passenger = new Passenger("Crazy", "Passenger", day, ts, "12345689710", rand.ToString());
                        customer.addPassenger(passenger);
                        newSeats.Add(rand);
                        customer.totalTicketCost += trip.price;
                    }
                    
                    ts.customer = customer;
                    Transport.makeRandomReservations(ts,newSeats,customer,reversed,customer.totalTicketCost,"roadway");
                }
            }
            foreach (Bus b in company2.busList)
            {
                until1 = random.Next(1, 2);
                for (int i = 1; i <= b.seat_count; i += until1)
                {
                    Trip trip;
                    Route route;

                    while (true)
                    {

                        while (true)
                        {
                            city1 = b.road.roadway[random.Next(0, b.road.roadway.Count)];
                            city2 = b.road.roadway[random.Next(0, b.road.roadway.Count)];

                            index1 = b.road.findIndex(city1, false);
                            index2 = b.road.findIndex(city2, false);

                            if (index1 == -1 || index2 == -1 || index1 == index2)
                            {
                                continue;
                            }
                            break;
                        }


                        if (index1 > index2)
                        {
                            reversed = true;
                        }
                        else
                        {
                            reversed = false;
                        }

                        route = new Route(city1, city2, "roadway");
                        trip = new Trip(route);
                        tripPrice = trip.price;

                        if (trip.price == 0)
                        {
                            continue;
                        }
                        break;
                    }


                    string day = days[random.Next(0, 7)];

                    Transport ts = new Transport(trip, "Otobüs", route, company2, b, day);
                    Customer customer = new Customer();
                    until2 = random.Next(0, 4);
                    List<int> newSeats = new List<int>();
                    int rand;
                    for (int j = 0; j < until2; j++)
                    {
                        rand = random.Next(1, b.seat_count);
                        Passenger passenger = new Passenger("Crazy", "Passenger", day, ts, "12345689710", rand.ToString());
                        customer.addPassenger(passenger);
                        newSeats.Add(rand);
                        customer.totalTicketCost += trip.price;
                    }

                    ts.customer = customer;
                    Transport.makeRandomReservations(ts, newSeats, customer, reversed, customer.totalTicketCost,"roadway");
                }
            }

            foreach (Bus b in company3.busList)
            {
                until1 = random.Next(1, 2);
                for (int i = 1; i <= b.seat_count; i += until1)
                {
                    Trip trip;
                    Route route;

                    while (true)
                    {

                        while (true)
                        {
                            city1 = b.road.roadway[random.Next(0, b.road.roadway.Count)];
                            city2 = b.road.roadway[random.Next(0, b.road.roadway.Count)];

                            index1 = b.road.findIndex(city1, false);
                            index2 = b.road.findIndex(city2, false);

                            if (index1 == -1 || index2 == -1 || index1 == index2)
                            {
                                continue;
                            }
                            break;
                        }


                        if (index1 > index2)
                        {
                            reversed = true;
                        }
                        else
                        {
                            reversed = false;
                        }

                        route = new Route(city1, city2, "roadway");
                        trip = new Trip(route);
                        tripPrice = trip.price;

                        if (trip.price == 0)
                        {
                            continue;
                        }
                        break;
                    }


                    string day = days[random.Next(0, 7)];

                    Transport ts = new Transport(trip, "Otobüs", route, company3, b, day);
                    Customer customer = new Customer();
                    until2 = random.Next(0, 4);
                    List<int> newSeats = new List<int>();
                    int rand;
                    for (int j = 0; j < until2; j++)
                    {
                        rand = random.Next(1, b.seat_count);
                        Passenger passenger = new Passenger("Crazy", "Passenger", day, ts, "12345689710", rand.ToString());
                        customer.addPassenger(passenger);
                        newSeats.Add(rand);
                        customer.totalTicketCost += trip.price;
                    }

                    ts.customer = customer;
                    Transport.makeRandomReservations(ts, newSeats, customer, reversed, customer.totalTicketCost, "roadway");
                }
            }
            
            foreach (Airplane b in company3.airplaneList)
            {
                until1 = random.Next(1, 2);
                for (int i = 1; i <= b.seat_count; i += until1)
                {
                    Trip trip;
                    Route route;

                    while (true)
                    {

                        while (true)
                        {
                            city1 = b.road.roadway[random.Next(0, b.road.roadway.Count)];
                            city2 = b.road.roadway[random.Next(0, b.road.roadway.Count)];

                            index1 = b.road.findIndex(city1, false);
                            index2 = b.road.findIndex(city2, false);

                            if (index1 == -1 || index2 == -1 || index1 == index2)
                            {
                                continue;
                            }
                            break;
                        }


                        if (index1 > index2)
                        {
                            reversed = true;
                        }
                        else
                        {
                            reversed = false;
                        }

                        route = new Route(city1, city2, "airway");
                        trip = new Trip(route);
                        tripPrice = trip.price;

                        if (trip.price == 0)
                        {
                            continue;
                        }
                        break;
                    }


                    string day = days[random.Next(0, 7)];

                    Transport ts = new Transport(trip, "Uçak", route, company3, b, day);
                    Customer customer = new Customer();
                    until2 = random.Next(0, 4);
                    List<int> newSeats = new List<int>();
                    int rand;
                    for (int j = 0; j < until2; j++)
                    {
                        rand = random.Next(1, b.seat_count);
                        Passenger passenger = new Passenger("Crazy", "Passenger", day, ts, "12345689710", rand.ToString());
                        customer.addPassenger(passenger);
                        newSeats.Add(rand);
                        customer.totalTicketCost += trip.price;
                    }

                    ts.customer = customer;
                    Transport.makeRandomReservations(ts, newSeats, customer, reversed, customer.totalTicketCost, "airway");
                }
            }
            foreach (Train b in company4.trainList)
            {
                until1 = random.Next(1, 2);
                for (int i = 1; i <= b.seat_count; i += until1)
                {
                    Trip trip;
                    Route route;

                    while (true)
                    {

                        while (true)
                        {
                            city1 = b.road.roadway[random.Next(0, b.road.roadway.Count)];
                            city2 = b.road.roadway[random.Next(0, b.road.roadway.Count)];

                            index1 = b.road.findIndex(city1, false);
                            index2 = b.road.findIndex(city2, false);

                            if (index1 == -1 || index2 == -1 || index1 == index2)
                            {
                                continue;
                            }
                            break;
                        }


                        if (index1 > index2)
                        {
                            reversed = true;
                        }
                        else
                        {
                            reversed = false;
                        }

                        route = new Route(city1, city2, "railway");
                        trip = new Trip(route);
                        tripPrice = trip.price;

                        if (trip.price == 0)
                        {
                            continue;
                        }
                        break;
                    }


                    string day = days[random.Next(0, 7)];

                    Transport ts = new Transport(trip, "Tren", route, company4, b, day);
                    Customer customer = new Customer();
                    until2 = random.Next(0, 4);
                    List<int> newSeats = new List<int>();
                    int rand;
                    for (int j = 0; j < until2; j++)
                    {
                        rand = random.Next(1, b.seat_count);
                        Passenger passenger = new Passenger("Crazy", "Passenger", day, ts, "12345689710", rand.ToString());
                        customer.addPassenger(passenger);
                        newSeats.Add(rand);
                        customer.totalTicketCost += trip.price;
                    }

                    ts.customer = customer;
                    Transport.makeRandomReservations(ts, newSeats, customer, reversed, customer.totalTicketCost, "railway");
                }
            }

            foreach (Airplane b in company5.airplaneList)
            {
                until1 = random.Next(1, 2);
                for (int i = 1; i <= b.seat_count; i += until1)
                {
                    Trip trip;
                    Route route;

                    while (true)
                    {

                        while (true)
                        {
                            city1 = b.road.roadway[random.Next(0, b.road.roadway.Count)];
                            city2 = b.road.roadway[random.Next(0, b.road.roadway.Count)];

                            index1 = b.road.findIndex(city1, false);
                            index2 = b.road.findIndex(city2, false);

                            if (index1 == -1 || index2 == -1 || index1 == index2)
                            {
                                continue;
                            }
                            break;
                        }


                        if (index1 > index2)
                        {
                            reversed = true;
                        }
                        else
                        {
                            reversed = false;
                        }

                        route = new Route(city1, city2, "airway");
                        trip = new Trip(route);
                        tripPrice = trip.price;

                        if (trip.price == 0)
                        {
                            continue;
                        }
                        break;
                    }


                    string day = days[random.Next(0, 7)];

                    Transport ts = new Transport(trip, "Uçak", route, company5, b, day);
                    Customer customer = new Customer();
                    until2 = random.Next(0, 4);
                    List<int> newSeats = new List<int>();
                    int rand;
                    for (int j = 0; j < until2; j++)
                    {
                        rand = random.Next(1, b.seat_count);
                        Passenger passenger = new Passenger("Crazy", "Passenger", day, ts, "12345689710", rand.ToString());
                        customer.addPassenger(passenger);
                        newSeats.Add(rand);
                        customer.totalTicketCost += trip.price;
                    }

                    ts.customer = customer;
                    Transport.makeRandomReservations(ts, newSeats, customer, reversed, customer.totalTicketCost, "airway");
                }
            }


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenu());
        }
    }
}
