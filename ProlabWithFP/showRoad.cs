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
    public partial class showRoad : Form
    {
        public string labelName = "";
        public bool isRoad;

        public List<City> Cities = new List<City>();
        public List<List<City>> doubledCities = new List<List<City>>();
        public List<List<City>> doubledCitiesReversed = new List<List<City>>();
        public showRoad()
        {
            InitializeComponent();
        }

        private void showRoad_Load(object sender, EventArgs e)
        {
            roadLabel.Text = labelName;
            if(isRoad == true)
            {
                foreach (City city in Cities)
                {
                    listBox1.Items.Add(city.name);
                }
            }
            else
            {
                foreach (List<City> cities in doubledCities)
                {
                    listBox1.Items.Add(cities[0].name + "-" + cities[1].name);
                }
                foreach (List<City> cities in doubledCitiesReversed)
                {
                    listBox1.Items.Add(cities[0].name + "-" + cities[1].name);
                }

            }
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
