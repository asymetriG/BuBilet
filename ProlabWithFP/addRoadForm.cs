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
    public partial class addRoadForm : Form
    {
        public Company company;
        public string waytype;
        public addRoadForm()
        {
            InitializeComponent();
        }

        private void addRoadForm_Load(object sender, EventArgs e)
        {
            if(waytype=="bus") {
                comboBox1.Items.Add("İstanbul");
                comboBox1.Items.Add("Kocaeli");
                comboBox1.Items.Add("Eskişehir");
                comboBox1.Items.Add("Ankara");
                comboBox1.Items.Add("Konya");
            }
            else if (waytype=="train")
            {
                comboBox1.Items.Add("İstanbul");
                comboBox1.Items.Add("Kocaeli");
                comboBox1.Items.Add("Eskişehir");
                comboBox1.Items.Add("Bilecik");
                comboBox1.Items.Add("Ankara");
                comboBox1.Items.Add("Konya");
            }

            
            comboBox1.SelectedIndex= 0;
        }

        private void addCity_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(comboBox1.SelectedItem);
            comboBox1.Items.Remove(comboBox1.SelectedItem);
            if(comboBox1.Items.Count==0)
            {
                addCity.Enabled = false;
                return;
            }
            comboBox1.SelectedIndex= 0;
            listBox1.SelectedIndex = 0;
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            List<City> list = new List<City>();
            foreach(string cityname in listBox1.Items)
            {
                City city = new City(cityname);
                list.Add(city);
            }
            Road road = new Road(list);
            if(waytype=="bus")
            {
                company.newBusRoads.Add(road);
            }
            else if (waytype == "train")
            {
                company.newTrainRoads.Add(road);
            }

            this.Close();
        }

        private void removeCity_Click(object sender, EventArgs e)
        {
            try
            {
                comboBox1.Items.Add(listBox1.SelectedItem);
                listBox1.Items.Remove(listBox1.SelectedItem);
                addCity.Enabled = true;
            }
            catch {
                
            }

            
        }
    }
}
