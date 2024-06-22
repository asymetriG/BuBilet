using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ComboBox = System.Windows.Forms.ComboBox;

namespace ProlabWithFP
{
    public partial class UserPanel : Form
    {
        public UserPanel()
        {
            InitializeComponent();
            
        }
   
        private void UserPanel_Load(object sender, EventArgs e)
        {

            ComboboxStart.Items.Add("İstanbul");
            ComboboxStart.Items.Add("Kocaeli");
            ComboboxStart.Items.Add("Ankara");
            ComboboxStart.Items.Add("Eskişehir");
            ComboboxStart.Items.Add("Konya");
            ComboboxStart.Items.Add("Bilecik");

            ComboboxFinish.Items.Add("İstanbul");
            ComboboxFinish.Items.Add("Kocaeli");
            ComboboxFinish.Items.Add("Ankara");
            ComboboxFinish.Items.Add("Eskişehir");
            ComboboxFinish.Items.Add("Konya");
            ComboboxFinish.Items.Add("Bilecik");

            datesBox.Items.Add("4 Aralık 2023");
            datesBox.Items.Add("5 Aralık 2023");
            datesBox.Items.Add("6 Aralık 2023");
            datesBox.Items.Add("7 Aralık 2023");
            datesBox.Items.Add("8 Aralık 2023");
            datesBox.Items.Add("9 Aralık 2023");
            datesBox.Items.Add("10 Aralık 2023");

            ComboboxStart.SelectedIndex = 0;
            ComboboxFinish.SelectedIndex = 1;

            datesBox.SelectedIndex = 0;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void findroute_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            int i = 0;
            if (ComboboxStart.SelectedIndex == -1 || ComboboxFinish.SelectedIndex == -1)
            {
                return;
            }

            string item1 = ComboboxStart.SelectedItem.ToString();
            string item2 = ComboboxFinish.SelectedItem.ToString();

            ComboboxStart.SelectedIndex= 0;
            ComboboxFinish.SelectedIndex = 0;


            foreach (Company company in Company.Companies)
            {
                foreach (Bus bus in company.busList)
                {
                    foreach (List<City> cities in bus.road.cityComb)
                    {
                        if (cities[0].name == item1 && cities[1].name == item2)
                        {
                            
                            Trip trip = new Trip(new Route(cities[0], cities[1], "roadway"));
                            if(trip.price!=0)
                            {
                                i = dataGridView1.Rows.Add();
                                dataGridView1.Rows[i].Cells[0].Value = company.name;
                                dataGridView1.Rows[i].Cells[1].Value = bus.name;
                                dataGridView1.Rows[i].Cells[2].Value = trip.route.departure;
                                dataGridView1.Rows[i].Cells[3].Value = trip.route.arrival;
                                dataGridView1.Rows[i].Cells[4].Value = "Otobüs";
                                dataGridView1.Rows[i].Cells[5].Value = trip.price;
                                dataGridView1.Rows[i].Cells[6].Value = datesBox.SelectedItem;
                                break;
                            }

                            
                        }
                    }
                    foreach (List<City> cities in bus.road.cityCombReversed)
                    {
                        if (cities[0].name == item1 && cities[1].name == item2)
                        {

                            Trip trip = new Trip(new Route(cities[0], cities[1], "roadway"));
                            if(trip.price!=0)
                            {
                                i = dataGridView1.Rows.Add();
                                dataGridView1.Rows[i].Cells[0].Value = company.name;
                                dataGridView1.Rows[i].Cells[1].Value = bus.name;
                                dataGridView1.Rows[i].Cells[2].Value = trip.route.departure;
                                dataGridView1.Rows[i].Cells[3].Value = trip.route.arrival;
                                dataGridView1.Rows[i].Cells[4].Value = "Otobüs";
                                dataGridView1.Rows[i].Cells[5].Value = trip.price;
                                dataGridView1.Rows[i].Cells[6].Value = datesBox.SelectedItem;
                                break;
                            }
                            

                            
                        }
                    }
                }
                foreach (Airplane airplane in company.airplaneList)
                {
                    foreach (List<City> cities in airplane.road.cityComb)
                    {
                        if (cities[0].name == item1 && cities[1].name == item2)
                        {
                            Trip trip = new Trip(new Route(cities[0], cities[1], "airway"));
                            if(trip.price!=0)
                            {
                                i = dataGridView1.Rows.Add();
                                dataGridView1.Rows[i].Cells[0].Value = company.name;
                                dataGridView1.Rows[i].Cells[1].Value = airplane.name;
                                dataGridView1.Rows[i].Cells[2].Value = trip.route.departure;
                                dataGridView1.Rows[i].Cells[3].Value = trip.route.arrival;
                                dataGridView1.Rows[i].Cells[4].Value = "Uçak";
                                dataGridView1.Rows[i].Cells[5].Value = trip.price;
                                dataGridView1.Rows[i].Cells[6].Value = datesBox.SelectedItem;
                                break;
                            }

                            
                        }
                    }
                    foreach (List<City> cities in airplane.road.cityCombReversed)
                    {
                        if (cities[0].name == item1 && cities[1].name == item2)
                        {
                            Trip trip = new Trip(new Route(cities[0], cities[1], "airway"));
                            if(trip.price!=0)
                            {
                                i = dataGridView1.Rows.Add();
                                dataGridView1.Rows[i].Cells[0].Value = company.name;
                                dataGridView1.Rows[i].Cells[1].Value = airplane.name;
                                dataGridView1.Rows[i].Cells[2].Value = trip.route.departure;
                                dataGridView1.Rows[i].Cells[3].Value = trip.route.arrival;
                                dataGridView1.Rows[i].Cells[4].Value = "Uçak";
                                dataGridView1.Rows[i].Cells[5].Value = trip.price;
                                dataGridView1.Rows[i].Cells[6].Value = datesBox.SelectedItem;
                                break;
                            }
                            
                        }
                    }
                }
                foreach (Train train in company.trainList)
                {
                    foreach (List<City> cities in train.road.cityComb)
                    {
                        if (cities[0].name == item1 && cities[1].name == item2)
                        {
                            Trip trip = new Trip(new Route(cities[0], cities[1], "railway"));
                            if(trip.price!=0)
                            {
                                i = dataGridView1.Rows.Add();
                                dataGridView1.Rows[i].Cells[0].Value = company.name;
                                dataGridView1.Rows[i].Cells[1].Value = train.name;
                                dataGridView1.Rows[i].Cells[2].Value = trip.route.departure;
                                dataGridView1.Rows[i].Cells[3].Value = trip.route.arrival;
                                dataGridView1.Rows[i].Cells[4].Value = "Tren";
                                dataGridView1.Rows[i].Cells[5].Value = trip.price;
                                dataGridView1.Rows[i].Cells[6].Value = datesBox.SelectedItem;
                                break;
                            }
                            
                        }
                    }
                    foreach (List<City> cities in train.road.cityCombReversed)
                    {
                        if (cities[0].name == item1 && cities[1].name == item2)
                        {
                            Trip trip = new Trip(new Route(cities[0], cities[1], "railway"));
                            if(trip.price!=0) {
                                i = dataGridView1.Rows.Add();
                                dataGridView1.Rows[i].Cells[0].Value = company.name;
                                dataGridView1.Rows[i].Cells[1].Value = train.name;
                                dataGridView1.Rows[i].Cells[2].Value = trip.route.departure;
                                dataGridView1.Rows[i].Cells[3].Value = trip.route.arrival;
                                dataGridView1.Rows[i].Cells[4].Value = "Tren";
                                dataGridView1.Rows[i].Cells[5].Value = trip.price;
                                dataGridView1.Rows[i].Cells[6].Value = datesBox.SelectedItem;
                                break;
                            }
                            
                        }
                    }
                }

            }

        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void viewSeats_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow;
            try
            {
                selectedRow = dataGridView1.SelectedRows[0];
            }
            catch(Exception ex)
            {
                MessageBox.Show("Hata");
                return;
            }
  
            string wayType = "";
            Company currentCompany = Company.searchCompany(selectedRow.Cells["Column1"].Value.ToString());
            Trip trip;
            Route route;
            Bus bus = null;
            Train train = null;
            Airplane airplane = null;
            int index1,index2;

            bool reversed = false;

            City departure = new City(selectedRow.Cells["Column3"].Value.ToString());
            City arrival = new City(selectedRow.Cells["Column4"].Value.ToString());
            
            Transport transport = null;


            if (selectedRow.Cells["Column5"].Value.ToString()=="Otobüs")
            {
                wayType = "roadway";
                bus = currentCompany.searchBus(selectedRow.Cells["Column2"].Value.ToString());

                index1 = bus.road.findIndex(departure,false);
                index2 = bus.road.findIndex(arrival, false);

                if(index1>index2)
                {
                    reversed = true;
                }
                else
                {
                    reversed = false;
                }

                route = new Route(departure, arrival, wayType);
                trip = new Trip(route);
                transport = new Transport(trip, selectedRow.Cells["Column5"].Value.ToString(), route, currentCompany,bus, selectedRow.Cells["Column7"].Value.ToString());
            }
            else if (selectedRow.Cells["Column5"].Value.ToString() == "Uçak")
            {
                wayType = "airway";
                route = new Route(departure, arrival, wayType);
                trip = new Trip(route);
                airplane = currentCompany.searchAirplane(selectedRow.Cells["Column2"].Value.ToString());

                index1 = airplane.road.findIndex(departure, false);
                index2 = airplane.road.findIndex(arrival, false);

                

                if (index1 > index2)
                {
                    reversed = true;
                }
                else
                {
                    reversed = false;
                }

                transport = new Transport(trip, selectedRow.Cells["Column5"].Value.ToString(), route, currentCompany, airplane, selectedRow.Cells["Column7"].Value.ToString());
                

            }
            else if (selectedRow.Cells["Column5"].Value.ToString() == "Tren")
            {
                wayType = "railway";
                route = new Route(departure, arrival, wayType);
                trip = new Trip(route);
                train = currentCompany.searchTrain(selectedRow.Cells["Column2"].Value.ToString());

                index1 = train.road.findIndex(departure, false);
                index2 = train.road.findIndex(arrival, false);

                if (index1 > index2)
                {
                    reversed = true;
                }
                else
                {
                    reversed = false;
                }

                transport = new Transport(trip, selectedRow.Cells["Column5"].Value.ToString(), route, currentCompany, train, selectedRow.Cells["Column7"].Value.ToString());
            }



            if (transport.vehicleType=="Otobüs")
            {
                if(bus.seat_count==20)
                {
                    busWithTwentySeats bwts = new busWithTwentySeats();
                    bwts.ts = transport;
                    bwts.reversed = reversed;
                    bwts.Show();
                }
                else if(bus.seat_count==15)
                {
                    busWithFifteenSeats bwfs = new busWithFifteenSeats();
                    bwfs.ts = transport;
                    bwfs.reversed = reversed;
                    bwfs.ShowDialog();
                }
            }
            else if (transport.vehicleType=="Tren")
            {
                if(train.seat_count==25)
                {
                    trainWithTwentyFiveSeats twtfs = new trainWithTwentyFiveSeats();
                    twtfs.ts = transport;
                    twtfs.reversed = reversed;
                    twtfs.ShowDialog();
                }
            }

            else if (transport.vehicleType == "Uçak")
            {
                if (airplane.seat_count == 30)
                {
                    planeWithThirtySeats pwts = new planeWithThirtySeats();
                    pwts.ts = transport;
                    pwts.reversed = reversed;
                    pwts.ShowDialog();
                }
            }


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void UserPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            BuyTicketPanel spp = new BuyTicketPanel();
            spp.Show();
            this.Hide();
        }

        private void ComboboxFinish_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
