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
    public partial class addVehicleForm : Form
    {
        public List<City> cities = new List<City>();
        public Road road;
        public Company company;
        public string waytype;
        public addVehicleForm()
        {
            InitializeComponent();
        }

        private void addVehicleForm_Load(object sender, EventArgs e)
        {
            if(waytype=="bus")
            {
                foreach (Road r in company.newBusRoads)
                {
                    comboBox1.Items.Add(r);
                }
                comboBox2.Items.Add("Benzin");
                comboBox2.Items.Add("Motorin");
                rb25.Enabled = false;
                rb30.Enabled= false;
                rb15.Select();
            }
            else if (waytype == "train")
            {
                foreach (Road r in company.newTrainRoads)
                {
                    comboBox1.Items.Add(r);
                }
                comboBox2.Items.Add("Elektrik");
                rb30.Enabled = false;
                rb15.Enabled = false;
                rb20.Enabled= false;
                rb25.Select();
            }
            else if (waytype == "plane")
            {
                foreach (Road r in company.newAirplaneRoads)
                {
                    comboBox1.Items.Add(r);
                }
                comboBox2.Items.Add("Elektrik");
                rb25.Enabled = false;
                rb20.Enabled = false;
                rb15.Enabled = false;
                rb30.Select();
            }

        }

        private void usernameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private bool validate()
        {
            if(driverPriceText.Text=="" || servicerPriceText.Text=="" || fuelPrice.Text=="")
            {
                return false;
            }
            if(vehicleName.Text=="" || !driverPriceText.Text.All(char.IsDigit) || !servicerPriceText.Text.All(char.IsDigit) || 
                !fuelPrice.Text.All(char.IsDigit) || comboBox1.SelectedIndex==-1 || comboBox2.SelectedIndex==-1)
            {
                return false;
            }
            return true;
        }

        private void addVehicle_Click(object sender, EventArgs e)
        {
            int selected = 0;
            if (!this.validate())
            {
                MessageBox.Show("Tüm bilgileri eksiksiz giriniz!");
                return;
            }

            if (waytype== "bus") {
                
                if(rb15.Checked)
                {
                    selected = 15; 
                }
                else
                {
                    selected = 20;
                }
                int seat = selected;
                string name = vehicleName.Text;
                int driverPrice = int.Parse(driverPriceText.Text);
                int servicerPrice = int.Parse(servicerPriceText.Text);
                Road road = (Road)comboBox1.SelectedItem;
                Fuel fuel = new Fuel(comboBox2.SelectedText,int.Parse(fuelPrice.Text));

                Personel driver = new Personel("Crazy", "Driver", driverPrice);
                Personel servicer = new Personel("Crazy", "Servicer", servicerPrice);

                Bus bus = new Bus(seat, road, name, driver, servicer, fuel);
                company.busList.Add(bus);
                this.Close();
            }
            else if (waytype == "train")
            {
                int seat = 25;
                string name = vehicleName.Text;
                int driverPrice = int.Parse(driverPriceText.Text);
                int servicerPrice = int.Parse(servicerPriceText.Text);
                Road road = (Road)comboBox1.SelectedItem;
                Fuel fuel = new Fuel(comboBox2.SelectedText, int.Parse(fuelPrice.Text));
                Personel driver = new Personel("Crazy", "Driver", driverPrice);
                Personel servicer = new Personel("Crazy", "Servicer", servicerPrice);

                Train train = new Train(seat, road, name, driver, servicer, fuel);
                company.trainList.Add(train);
                this.Close();
            }
            else if (waytype == "plane")
            {
                int seat = 30;
                string name = vehicleName.Text;
                int driverPrice = int.Parse(driverPriceText.Text);
                int servicerPrice = int.Parse(servicerPriceText.Text);
                Road road = (Road)comboBox1.SelectedItem;
                Fuel fuel = new Fuel(comboBox2.SelectedText, int.Parse(fuelPrice.Text));
                Personel driver = new Personel("Crazy", "Driver", driverPrice);
                Personel servicer = new Personel("Crazy", "Servicer", servicerPrice);

                Airplane airplane = new Airplane(seat, road, name, driver, servicer, fuel);
                company.airplaneList.Add(airplane);
                this.Close();
            }


        }

        private void b15_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void b20_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb25_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb30_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
