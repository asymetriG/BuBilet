using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProlabWithFP
{
    public partial class busWithFifteenSeats : Form
    {
        public int buttonNumber = -1;
        public Transport ts;
        public int numberOfPeople = 1;
        public int totalPrice;
        public int kalanPara;
        public bool reversed;
        Customer costumer;
        public busWithFifteenSeats()
        {

            InitializeComponent();
        }

        private void busWithFifteenSeats_Load(object sender, EventArgs e)
        {
            this.reloadSeats();
            this.costumer = new Customer();
            this.costumer.totalTicketCost = ts.trip.price;

            totalPrice = ts.trip.price;
            kalanPara = ts.trip.price;

            numberOfPeopleText.Text = numberOfPeople.ToString();
            totalPriceText.Text = totalPrice.ToString();

            remainPrice.Text = kalanPara.ToString();
            selectedSeat.Text = "Seçilmedi";

        }
        private Button FindButtonByName(string buttonName)
        {
            foreach (Control control in this.Controls)
            {
                if (control is Button && control.Name == buttonName)
                {
                    return (Button)control;
                }
            }

            return null;
        }

        public bool IsNumericStringWithLength(string input, int expectedLength)
        {

            if (!string.IsNullOrEmpty(input) && input.All(char.IsDigit))
            {

                return input.Length == expectedLength;
            }

            return false;
        }

        public bool validate()
        {
            if(nameText.Text=="" || surnameText.Text=="" || this.buttonNumber==-1 || !IsNumericStringWithLength(tcText.Text,11)) {
                MessageBox.Show("Lütfen Tüm Bilgileri Eksiksiz Doldurunuz!");
                return false;
            }

            return true;
        }

        public void reloadSeats()
        {
            if(!reversed)
            {
                int dI = this.ts.bus.road.roadwayString.IndexOf(this.ts.route.departure.name);
                int aI = this.ts.bus.road.roadwayString.IndexOf(this.ts.route.arrival.name);

                Dictionary<List<string>, List<int>> currentSeats = ts.bus.dailySeats[ts.day];

                int index1 = 0;
                int index2 = 0;
                Button foundButton;

                Dictionary<int, bool> founds = new Dictionary<int, bool>();
                for (int i = 1; i <= ts.bus.seat_count; i++)
                {
                    founds[i] = false;
                }

                foreach (KeyValuePair<List<string>, List<int>> seats in currentSeats)
                {
                    index1 = ts.bus.road.roadwayString.IndexOf(seats.Key[0]);
                    index2 = ts.bus.road.roadwayString.IndexOf(seats.Key[1]);

                    if (index1 >= dI && index2 <= aI)
                    {
                        for (int i = 0; i < ts.bus.seat_count; i++)
                        {
                            if (seats.Value[i] == 1)
                            {
                                foundButton = FindButtonByName("button" + (i + 1).ToString());
                                foundButton.Text = "Doldu";
                                foundButton.BackColor = Color.Red;
                                founds[i + 1] = true;
                            }
                            else
                            {
                                if (!founds[i + 1])
                                {
                                    foundButton = FindButtonByName("button" + (i + 1).ToString());
                                    foundButton.Text = (i + 1).ToString();
                                    foundButton.BackColor = Color.Green;
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                int dI = this.ts.bus.road.reversedRoadwayString.IndexOf(this.ts.route.departure.name);
                int aI = this.ts.bus.road.reversedRoadwayString.IndexOf(this.ts.route.arrival.name);

                Dictionary<List<string>, List<int>> currentSeats = ts.bus.reversedDailySeats[ts.day];

                int index1 = 0;
                int index2 = 0;
                Button foundButton;

                Dictionary<int, bool> founds = new Dictionary<int, bool>();
                for (int i = 1; i <= ts.bus.seat_count; i++)
                {
                    founds[i] = false;
                }

                foreach (KeyValuePair<List<string>, List<int>> seats in currentSeats)
                {
                    index1 = ts.bus.road.reversedRoadwayString.IndexOf(seats.Key[0]);
                    index2 = ts.bus.road.reversedRoadwayString.IndexOf(seats.Key[1]);

                    if (index1 >= dI && index2 <= aI)
                    {
                        for (int i = 0; i < ts.bus.seat_count; i++)
                        {
                            if (seats.Value[i] == 1)
                            {
                                foundButton = FindButtonByName("button" + (i + 1).ToString());
                                foundButton.Text = "Doldu";
                                foundButton.BackColor = Color.Red;
                                founds[i + 1] = true;
                            }
                            else
                            {
                                if (!founds[i + 1])
                                {
                                    foundButton = FindButtonByName("button" + (i + 1).ToString());
                                    foundButton.Text = (i + 1).ToString();
                                    foundButton.BackColor = Color.Green;
                                    founds[i + 1] = true;
                                }
                            }
                        }
                    }
                }
            }
            


        }
        private void biletAl()
        {
            int dI;
            int aI;

            if(!reversed)
            {
                dI = this.ts.bus.road.roadwayString.IndexOf(this.ts.route.departure.name);
                aI = this.ts.bus.road.roadwayString.IndexOf(this.ts.route.arrival.name);
            }
            else
            {
                dI = this.ts.bus.road.reversedRoadwayString.IndexOf(this.ts.route.departure.name);
                aI = this.ts.bus.road.reversedRoadwayString.IndexOf(this.ts.route.arrival.name);
            }
            

            if(!validate())
            {
                return;
            }

            this.addPeople.Enabled = false;
            this.removePeople.Enabled = false;

            int index1 = 0;
            int index2 = 0;
            int found = 0;

            Dictionary<List<string>, List<int>> currentSeats;

            List<KeyValuePair<List<string>, List<int>>> seatsToUpdate = new List<KeyValuePair<List<string>, List<int>>>();
            if(!reversed)
            {
                currentSeats = ts.bus.dailySeats[ts.day];
            }
            else
            {
                currentSeats = ts.bus.reversedDailySeats[ts.day];
            }
            

            foreach (KeyValuePair<List<string>, List<int>> seats in currentSeats)
            {
                if(!reversed)
                {
                    index1 = ts.bus.road.roadwayString.IndexOf(seats.Key[0]);
                    index2 = ts.bus.road.roadwayString.IndexOf(seats.Key[1]);
                }
                else
                {
                    index1 = ts.bus.road.reversedRoadwayString.IndexOf(seats.Key[0]);
                    index2 = ts.bus.road.reversedRoadwayString.IndexOf(seats.Key[1]);
                }
                

                if (index1 >= dI && index2 <= aI)
                {
                    if (seats.Value[this.buttonNumber - 1] == 1)
                    {
                        found = 1;
                        break;
                    }
                    seatsToUpdate.Add(seats);
                }
            }

            if (found == 0)
            {
                ts.confirmReservation(ts, this.buttonNumber, reversed, seatsToUpdate);

                kalanPara -= ts.trip.price;
                remainPrice.Text = kalanPara.ToString();
                string dateOfBorn = monthCalendar1.SelectionRange.Start.ToString("dd MMM yyyy");
                Passenger passenger = new Passenger(nameText.Text, surnameText.Text, dateOfBorn, this.ts, tcText.Text, selectedSeat.Text);
                this.costumer.addPassenger(passenger);

                this.selectedSeat.Text = "Seçilmedi";
                this.buttonNumber = -1;

                nameText.Clear();
                surnameText.Clear();
                tcText.Clear();

                this.reloadSeats();

                MessageBox.Show("Rezervasyon Yapildi");
                numberOfPeople--;

                
                if(numberOfPeople == 0)
                {
                    ts.customer = this.costumer;
                    

                    string ticketText = "";

                    for (int i = 0;i<ts.customer.passengers.Count;i++)
                    {
                        
                        ticketText = "";
                        ticketText += "İsim : " + ts.customer.passengers[i].name + "\n\n";
                        ticketText += "Soyisim : " + ts.customer.passengers[i].surname + "\n\n";
                        ticketText += "Doğum Tarihi : " + ts.customer.passengers[i].dateOfBorn + "\n\n";
                        ticketText += "TC : " + ts.customer.passengers[i].TC.Substring(0, 3) + "********" + "\n\n";
                        ticketText += "Seçilen Koltuk : " + ts.customer.passengers[i].seat + "\n\n";
                        ticketText += "Kalkış : " + ts.route.arrival.name + "\n\n";
                        ticketText += "Varış : " + ts.route.departure.name + "\n\n";
                        ticketText += "Ücret : " + ts.trip.price + "\n\n";
                        Reservation res = new Reservation(ts.customer.passengers[i],ts.route.arrival.name,ts.route.departure.name,ts.trip.price);
                        ts.customer.passengers[i].res = res;
                        MessageBox.Show(ticketText);
                    }
                    ts.company.currentTickets.Add(this.ts);

                    this.Close();
                    return;
                }
                numberOfPeopleText.Text = numberOfPeople.ToString();        
                
            }
            else
            {
                Button foundButton = FindButtonByName("button" + this.buttonNumber.ToString());
                foundButton.Text = "Doldu";
                foundButton.Enabled = false;
                MessageBox.Show("Rezervasyon DOLUUUUUU!!!");
            }

        }

        

        public void optimizeButtonColours()
        {
            Button foundButton = FindButtonByName("button"+this.buttonNumber.ToString());
            if(foundButton.BackColor == Color.Green)
            {
                foundButton.BackColor = Color.Blue;
                selectedSeat.Text = this.buttonNumber.ToString();
            }
            if(foundButton.BackColor == Color.Red)
            {
                for (int i = 1; i <= ts.bus.seat_count; i++)
                {
                    foundButton = FindButtonByName("button" + i.ToString());
                    if (foundButton.BackColor == Color.Blue)
                    {
                        foundButton.BackColor = Color.Green;
                        break;
                    }
                }
                this.buttonNumber = -1;
                this.selectedSeat.Text = "Seçilmedi";
                return;
            }
            for(int i = 1;i<=ts.bus.seat_count;i++)
            {
                foundButton = FindButtonByName("button"+i.ToString());
                if(foundButton.Name!="button"+this.buttonNumber.ToString() && foundButton.BackColor!=Color.Red)
                {
                    foundButton.BackColor = Color.Green;
                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.buttonNumber = 1;
            optimizeButtonColours();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.buttonNumber = 2;
            optimizeButtonColours();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.buttonNumber = 3;
            optimizeButtonColours();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.buttonNumber = 4;
            optimizeButtonColours();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.buttonNumber = 5;
            optimizeButtonColours();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.buttonNumber = 6;
            optimizeButtonColours();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.buttonNumber = 7;
            optimizeButtonColours();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.buttonNumber = 8;
            optimizeButtonColours();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.buttonNumber = 9;
            optimizeButtonColours();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.buttonNumber = 10;
            optimizeButtonColours();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.buttonNumber = 11;
            optimizeButtonColours();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.buttonNumber = 12;
            optimizeButtonColours();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.buttonNumber = 13;
            optimizeButtonColours();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.buttonNumber = 14;
            optimizeButtonColours();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.buttonNumber = 15;
            optimizeButtonColours();
        }

        private void nameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void changePeopleCount_Click(object sender, EventArgs e)
        {

        }

        private void addPeople_Click(object sender, EventArgs e)
        {
            if(numberOfPeople>=ts.bus.seat_count)
            {
                MessageBox.Show("En fazla " + ts.bus.seat_count + " adet kişi girebilirsiniz!");
            }
            else
            {
                numberOfPeople++;
                numberOfPeopleText.Text = numberOfPeople.ToString();
                totalPrice += ts.trip.price;
                this.costumer.totalTicketCost = totalPrice;
                totalPriceText.Text = totalPrice.ToString();
                kalanPara += ts.trip.price;
                remainPrice.Text = kalanPara.ToString();
            }
            
        }

        private void removePeople_Click(object sender, EventArgs e)
        {
            if (numberOfPeople <= 1)
            {
                MessageBox.Show("En az 1 kişi olmak zorundadır!");
            }
            else
            {
                numberOfPeople--;
                numberOfPeopleText.Text = numberOfPeople.ToString();
                totalPrice -= ts.trip.price;
                this.costumer.totalTicketCost = totalPrice;
                totalPriceText.Text = totalPrice.ToString();
                kalanPara -= ts.trip.price;
                remainPrice.Text = kalanPara.ToString();
            }
        }

        private void remainingPriceText_Click(object sender, EventArgs e)
        {

        }

        private void buyTicket_Click(object sender, EventArgs e)
        {
            this.biletAl();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
