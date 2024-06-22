using System;
using System.Collections;
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
    public partial class FirmPanel : Form
    {
        public Company company;

        public Bus selectedBus;
        public Airplane selectedAirplane;
        public Train selectedTrain;
        bool hasVehicle = false;
        bool hasNewRoadBus = false;
        bool hasNewRoadAirplane = false;
        bool hasNewRoadTrain = false;
        public int dailyCost = 0;

        public FirmPanel()
        {
            InitializeComponent();
        }

        
        private void FirmPanel_Load(object sender, EventArgs e)
        {
            this.reloadPage();
        }

        public void reloadPage()
        {
            labell.Text = company.name;
            buses.Items.Clear();
            planes.Items.Clear();
            trains.Items.Clear();
            listBox1.Items.Clear();
            hasVehicle = false;
            hasNewRoadBus = false;
            hasNewRoadAirplane = false;
            hasNewRoadTrain = false;

            if (company.newAirplaneRoads.Count>0)
            {
                hasNewRoadAirplane = true;
            }
            if (company.newBusRoads.Count > 0)
            {
                hasNewRoadBus = true;
            }
            if (company.newTrainRoads.Count > 0)
            {
                hasNewRoadTrain = true;
            }

            if (company.busList.Count != 0)
            {
                hasVehicle= true;
                foreach (Bus b in company.busList)
                {
                    buses.Items.Add(b.name);
                }
            }

            if (company.airplaneList.Count != 0)
            {
                hasVehicle = true;
                foreach (Airplane a in company.airplaneList)
                {
                    planes.Items.Add(a.name);
                }
            }

            if (company.trainList.Count != 0)
            {
                hasVehicle = true;
                foreach (Train t in company.trainList)
                {
                    trains.Items.Add(t.name);
                }
            }

            foreach (Transport ticket in company.currentTickets)
            {
                listBox1.Items.Add(ticket);
            }

            this.dailyCost = 0;
            
            int weeklyCost = 0;
            int totalEarnings = 0;
            int totalProfit = 0;

            company.calculateProfit(out this.dailyCost,out weeklyCost,out totalEarnings,out totalProfit);

            dailyCostText.Text = dailyCost.ToString();
            weeklyCostText.Text = weeklyCost.ToString();
            totalEarningsText.Text = totalEarnings.ToString();

            if(totalProfit < 0)
            {
                totalProfitText.Text = (totalProfit * -1) + " TL Zarar";
            }
            else
            {
                totalProfitText.Text = totalProfit + " TL Kar";
            }
            
            
        }


        private void getBusRoad_Click(object sender, EventArgs e)
        {


            if(company != null)
            {
                if(buses.SelectedIndex!=-1)
                {
                    Bus bus = (Bus)company.busList[buses.SelectedIndex];
                    showRoad sr = new showRoad();
                    sr.isRoad = true;
                    sr.Cities = bus.road.roadway;
                    sr.labelName = "Güzergah";
                    sr.ShowDialog();
                }
                
            }
        }

        private void getPlaneRoad_Click(object sender, EventArgs e)
        {


            if (company != null)
            {
                if(planes.SelectedIndex!=-1)
                {
                    Airplane airplane = (Airplane)company.airplaneList[planes.SelectedIndex];

                    showRoad sr = new showRoad();
                    sr.isRoad = true;
                    sr.Cities = airplane.road.roadway;
                    sr.labelName = "Güzergah";

                    sr.ShowDialog();
                } 
                
            }
        }

        private void getTrainRoad_Click(object sender, EventArgs e)
        {


            if (company != null)
            {
                if(trains.SelectedIndex!=-1)
                {
                    Train train = (Train)company.trainList[trains.SelectedIndex];

                    showRoad sr = new showRoad();
                    sr.isRoad = true;
                    sr.Cities = train.road.roadway;
                    sr.labelName = "Güzergah";

                    sr.ShowDialog();
                }             
            }
        }

        private void showRoutesBus_Click(object sender, EventArgs e)
        {
            if (buses.SelectedIndex != -1)
            {
                Bus bus = (Bus)company.busList[buses.SelectedIndex];

                showRoad sr = new showRoad();

                sr.isRoad= false;
                sr.doubledCities = bus.road.cityComb;
                sr.doubledCitiesReversed = bus.road.cityCombReversed;
                sr.Show();
            }
            else
            {
                MessageBox.Show("Lütfen Bir Otobüs Seçiniz!");
            }
        }

        private void showRoutesPlane_Click(object sender, EventArgs e)
        {
            if (planes.SelectedIndex != -1)
            {
                Airplane airplane = (Airplane)company.airplaneList[planes.SelectedIndex];

                showRoad sr = new showRoad();

                sr.isRoad = false;
                sr.doubledCities = airplane.road.cityComb;
                sr.doubledCitiesReversed = airplane.road.cityCombReversed;
                sr.Show();
            }
            else
            {
                MessageBox.Show("Lütfen Bir Uçak Seçiniz!");
            }
        }

        private void showRoutesTrain_Click(object sender, EventArgs e)
        {
            if (trains.SelectedIndex != -1)
            {
                Train train = (Train)company.trainList[trains.SelectedIndex];

                showRoad sr = new showRoad();

                sr.isRoad = false;
                sr.doubledCities = train.road.cityComb;
                sr.doubledCitiesReversed = train.road.cityCombReversed;
                sr.Show();
            }
            else
            {
                MessageBox.Show("Lütfen Bir Tren Seçiniz!");
            }
        }

        

        private void removeRoadBus_Click(object sender, EventArgs e)
        {
            if(hasNewRoadBus)
            {
                removeRoadForm rrf = new removeRoadForm();
                rrf.company = company;
                rrf.wayType = "bus";
                rrf.ShowDialog();
            }
            else
            {
                MessageBox.Show("Hiç yeni otobüs seferi yok");
            }
            
        }

        private void removeRoadTrain_Click(object sender, EventArgs e)
        {
            if (hasNewRoadTrain)
            {
                removeRoadForm rrf = new removeRoadForm();
                rrf.company = company;
                rrf.wayType = "train";
                rrf.ShowDialog();
            }
            else
            {
                MessageBox.Show("Hiç yeni tren seferi yok");
            }
            
        }

        private void addRoadTrain_Click(object sender, EventArgs e)
        {
            string waytype = "train";

            addRoadForm arf = new addRoadForm();
            arf.company = company;
            arf.waytype = waytype;

            arf.ShowDialog();
        }

        private void removeRoadPlane_Click(object sender, EventArgs e)
        {
            if (hasNewRoadAirplane)
            {
                removeRoadForm rrf = new removeRoadForm();
                rrf.company = company;
                rrf.wayType = "airplane";
                rrf.ShowDialog();
            }
            else
            {
                MessageBox.Show("Hiç yeni tren seferi yok");
            }
            
        }

        private void addRoadPlane_Click(object sender, EventArgs e)
        {

        }

        private void addRoadBus_Click(object sender, EventArgs e)
        {
            string waytype = "bus";

            addRoadForm arf = new addRoadForm();
            arf.company = company;
            arf.waytype = waytype;

            arf.ShowDialog();
        }

        private void removeVehicleTrain_Click(object sender, EventArgs e)
        {

        }

        private void addVehiclePlane_Click(object sender, EventArgs e)
        {
            addVehicleForm avf = new addVehicleForm();
            avf.company = company;
            avf.waytype = "plane";
            avf.ShowDialog();
        }

        private void addVehicleBus_Click(object sender, EventArgs e)
        {
            addVehicleForm avf = new addVehicleForm();
            avf.company = company;
            avf.waytype = "bus";
            avf.ShowDialog();
        }

        private void addVehicleTrain_Click(object sender, EventArgs e)
        {
            addVehicleForm avf = new addVehicleForm();
            avf.company = company;
            avf.waytype = "train";
            avf.ShowDialog();
        }

        private void removeVehiclePlane_Click(object sender, EventArgs e)
        {

        }

        private void removeVehicleBus_Click(object sender, EventArgs e)
        {

        }

        private void reloadButton_Click(object sender, EventArgs e)
        {
            this.reloadPage();
        }

        private void showTicket_Click(object sender, EventArgs e)
        {
            Transport transport;
            if(listBox1.Items.Count>0)
            {
                if(listBox1.SelectedIndex!=-1)
                {
                    transport = (Transport)listBox1.SelectedItem;
                    foreach(Passenger p in transport.customer.passengers)
                    {
                        MessageBox.Show(p.ToString());
                    }
                }
            }
        }

        private void removeVehicle_Click(object sender, EventArgs e)
        {
            if(hasVehicle)
            {
                removeVehicleForm rvf = new removeVehicleForm();
                rvf.company = company;
                rvf.ShowDialog();
            }
            else
            {
                MessageBox.Show("Hiç araç yok.");
            }
            
        }

        private void dailyProfitShow_Click(object sender, EventArgs e)
        {
            dailyProfitForm dpf = new dailyProfitForm();
            dpf.dailycost = dailyCost;
            dpf.company = company;
            dpf.ShowDialog();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FirmPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainMenu mm = new MainMenu();
            mm.Show();
        }
    }
}
