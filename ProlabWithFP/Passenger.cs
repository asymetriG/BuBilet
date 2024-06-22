using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProlabWithFP
{
    public class Passenger : Person
    {
        public string dateOfBorn { get; set; }
        public string TC { get; set; }
        public string seat { get; set; }
        public Transport ts { get; set; }
        public Reservation res { get; set; }
        public Passenger(string name, string surname, string dateOfBorn, Transport ts,string TC,string seat)
        {
            this.name = name;
            this.surname = surname;
            this.dateOfBorn = dateOfBorn;
            this.ts = ts;   
            this.TC = TC;
            this.seat= seat;
        }

        public override string ToString() {
            string maintext = "";
            maintext += "İsim : " + this.name + "\n\n";
            maintext += "Soyisim : " + this.surname + "\n\n";
            maintext += "Doğum Tarihi : " + this.dateOfBorn + "\n\n";
            maintext += "TC : " + this.TC.Substring(0, 3) + "********" + "\n\n";
            maintext += "Seçilen Koltuk : " + this.seat + "\n\n";
            maintext += "Kalkış : " + this.res.departure + "\n\n";
            maintext += "Varış : " + this.res.arrival + "\n\n";
            maintext += "Ücret : " + ts.trip.price + "\n\n";

            return maintext;
        }
    }
}
