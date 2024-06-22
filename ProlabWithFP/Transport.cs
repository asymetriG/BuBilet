using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProlabWithFP
{
    public class Transport : IReservable
    {
        public Trip trip { get; set; }
        public string vehicleType { get; set; }
        public string day { get; set; }
        public Route route { get; set; }
        public Company company { get; set; }
        public Vehicle vehicle { get; set; }
        public Bus bus = null;
        public Airplane airplane = null;
        public Train train = null;
        public Customer customer { get; set; }
        public Reservation reservation { get; set; }


        public Transport(Trip trip, string vehicleType, Route route, Company company, Vehicle vehicle, string day)
        {
            this.trip = trip;
            this.vehicleType = vehicleType;
            this.route = route;
            this.company = company;
            this.day = day;
            this.vehicle = vehicle;

            if (vehicle is Bus)
            {
                this.bus = (Bus)vehicle;
            }
            else if (vehicle is Airplane)
            {
                this.airplane = (Airplane)vehicle;
            }
            else if (vehicle is Train)
            {
                this.train = (Train)vehicle;
            }
        }

        public void confirmReservation(Transport ts, int seat, bool reversed, List<KeyValuePair<List<string>, List<int>>> seatsToUpdate)
        {
            if (vehicleType == "Otobüs")
            {
                foreach (KeyValuePair<List<string>, List<int>> seats in seatsToUpdate)
                {
                    List<int> newArray = new List<int>(seats.Value);
                    newArray[seat - 1] = 1;
                    if (!reversed)
                    {
                        ts.bus.dailySeats[ts.day][seats.Key] = newArray;
                    }
                    else
                    {
                        ts.bus.reversedDailySeats[ts.day][seats.Key] = newArray;
                    }
                }
            }
            else if (vehicleType == "Uçak")
            {
                foreach (KeyValuePair<List<string>, List<int>> seats in seatsToUpdate)
                {
                    List<int> newArray = new List<int>(seats.Value);
                    newArray[seat - 1] = 1;
                    if (!reversed)
                    {
                        ts.airplane.dailySeats[ts.day][seats.Key] = newArray;
                    }
                    else
                    {
                        ts.airplane.reversedDailySeats[ts.day][seats.Key] = newArray;
                    }
                }
            }
            else if (vehicleType == "Tren")
            {
                foreach (KeyValuePair<List<string>, List<int>> seats in seatsToUpdate)
                {
                    List<int> newArray = new List<int>(seats.Value);
                    newArray[seat - 1] = 1;
                    if (!reversed)
                    {
                        ts.train.dailySeats[ts.day][seats.Key] = newArray;
                    }
                    else
                    {
                        ts.train.reversedDailySeats[ts.day][seats.Key] = newArray;
                    }
                }
            }

        }

        public static void makeRandomReservations(Transport ts, List<int> newSeats,Customer customer, bool reversed,int price,string waytype)
        {

            int dI = 0;
            int aI = 0;

            if (!reversed)
            {
                if(waytype=="roadway")
                {
                    dI = ts.bus.road.roadwayString.IndexOf(ts.route.departure.name);
                    aI = ts.bus.road.roadwayString.IndexOf(ts.route.arrival.name);
                }
                else if(waytype=="railway")
                {
                    dI = ts.train.road.roadwayString.IndexOf(ts.route.departure.name);
                    aI = ts.train.road.roadwayString.IndexOf(ts.route.arrival.name);
                }
                else if(waytype=="airway")
                {
                    dI = ts.airplane.road.roadwayString.IndexOf(ts.route.departure.name);
                    aI = ts.airplane.road.roadwayString.IndexOf(ts.route.arrival.name);
                }
                
            }
            else
            {

                if (waytype == "roadway")
                {
                    dI = ts.bus.road.reversedRoadwayString.IndexOf(ts.route.departure.name);
                    aI = ts.bus.road.reversedRoadwayString.IndexOf(ts.route.arrival.name);
                }
                else if (waytype == "railway")
                {
                    dI = ts.train.road.reversedRoadwayString.IndexOf(ts.route.departure.name);
                    aI = ts.train.road.reversedRoadwayString.IndexOf(ts.route.arrival.name);
                }
                else if (waytype == "airway")
                {
                    dI = ts.airplane.road.reversedRoadwayString.IndexOf(ts.route.departure.name);
                    aI = ts.airplane.road.reversedRoadwayString.IndexOf(ts.route.arrival.name);
                }
             
            }


            int index1 = 0;
            int index2 = 0;
            int found = 0;

            Dictionary<List<string>, List<int>> currentSeats = new Dictionary<List<string>, List<int>>();

            List<KeyValuePair<List<string>, List<int>>> seatsToUpdate = new List<KeyValuePair<List<string>, List<int>>>();
            if (!reversed)
            {
                if(waytype=="roadway")
                {
                    currentSeats = ts.bus.dailySeats[ts.day];
                }
                else if(waytype=="railway")
                {
                    currentSeats = ts.train.dailySeats[ts.day];
                }
                else if(waytype=="airway")
                {
                    currentSeats = ts.airplane.dailySeats[ts.day];
                }
                
            }
            else
            {
                if (waytype == "roadway")
                {
                    currentSeats = ts.bus.reversedDailySeats[ts.day];
                }
                else if (waytype == "railway")
                {
                    currentSeats = ts.train.reversedDailySeats[ts.day];
                }
                else if (waytype == "airway")
                {
                    currentSeats = ts.airplane.reversedDailySeats[ts.day];
                }
            }

            foreach(int seat in newSeats)
            {
                foreach (KeyValuePair<List<string>, List<int>> seats in currentSeats)
                {
                    if (!reversed)
                    {
                        if(waytype=="roadway")
                        {
                            index1 = ts.bus.road.roadwayString.IndexOf(seats.Key[0]);
                            index2 = ts.bus.road.roadwayString.IndexOf(seats.Key[1]);
                        }
                        else if(waytype=="railway")
                        {
                            index1 = ts.train.road.roadwayString.IndexOf(seats.Key[0]);
                            index2 = ts.train.road.roadwayString.IndexOf(seats.Key[1]);
                        }
                        else if(waytype=="airway")
                        {
                            index1 = ts.airplane.road.roadwayString.IndexOf(seats.Key[0]);
                            index2 = ts.airplane.road.roadwayString.IndexOf(seats.Key[1]);
                        }
                        
                    }
                    else
                    {
                        if (waytype == "roadway")
                        {
                            index1 = ts.bus.road.reversedRoadwayString.IndexOf(seats.Key[0]);
                            index2 = ts.bus.road.reversedRoadwayString.IndexOf(seats.Key[1]);
                        }
                        else if (waytype == "railway")
                        {
                            index1 = ts.train.road.reversedRoadwayString.IndexOf(seats.Key[0]);
                            index2 = ts.train.road.reversedRoadwayString.IndexOf(seats.Key[1]);
                        }
                        else if (waytype == "airway")
                        {
                            index1 = ts.airplane.road.reversedRoadwayString.IndexOf(seats.Key[0]);
                            index2 = ts.airplane.road.reversedRoadwayString.IndexOf(seats.Key[1]);
                        }
                    }


                    if (index1 >= dI && index2 <= aI)
                    {
                        if (seats.Value[seat - 1] == 1)
                        {
                            found = 1;
                            break;
                        }
                        seatsToUpdate.Add(seats);
                    }
                }

                if (found == 0)
                {
                    ts.confirmReservation(ts, seat, reversed, seatsToUpdate);

                    for (int i = 0; i < customer.passengers.Count; i++)
                    {
                        Reservation res = new Reservation(customer.passengers[i], ts.route.arrival.name, ts.route.departure.name, ts.trip.price);
                        customer.passengers[i].res = res;
                    }
                    customer.totalTicketCost = price;
                    ts.customer = customer;
                    ts.company.currentTickets.Add(ts);

                    return;
                }
                return;
            }      
        }

    public override string ToString()
    {
            string maintext = "" + this.day + " tarihli " + customer.passengers.Count.ToString() + " kişilik " + this.vehicleType.ToLower() + " bileti (" + this.vehicle.name + ") " + "("+this.customer.totalTicketCost+")  TL";
        return maintext;

    }
    } 
}


        
